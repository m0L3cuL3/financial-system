using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financial_System.Utils
{

    interface ISQLite
    {
        SQLiteConnection CreateConnection();
        Task CreateTable(SQLiteConnection conn);
    }
    /// 
    /// TODO: make methods async to increase performance.
    /// 
    class SQLiteHandler : ISQLite
    {

        public SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;

            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = True; Compress = True; ");

            // Open the connection:          
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return sqlite_conn;
        }

        // Create Tables
        public async Task CreateTable(SQLiteConnection conn)
        {

            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;

                // STUDENT //
                ///
                /// Added LRN
                ///
                string StudentTable = "CREATE TABLE IF NOT EXISTS Student_tbl(student_id INTEGER PRIMARY KEY AUTOINCREMENT, student_lrn INT NOT NULL UNIQUE, first_name VARCHAR NOT NULL, middle_name VARCHAR NOT NULL, surname VARCHAR NOT NULL, section VARCHAR NOT NULL, level INT NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = StudentTable;
                sqlite_cmd.ExecuteNonQuery();

                // TRANSACTION // renamed by alexislyndon
                string TransactionTable = "CREATE TABLE IF NOT EXISTS Transaction_tbl(transaction_id INTEGER PRIMARY KEY AUTOINCREMENT, amount INT NOT NULL, type VARCHAR NOT NULL, student_id INT NOT NULL, receipt_number VARCHAR NOT NULL, term INT NOT NULL, date_recorded DATE NOT NULL, user INT NULL, FOREIGN KEY(student_id) REFERENCES Student_tbl(student_id), FOREIGN KEY(term) REFERENCES Term_tbl(term_id), FOREIGN KEY(user) REFERENCES User_tbl(user_id));";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = TransactionTable;
                sqlite_cmd.ExecuteNonQuery();

                // TERM //
                string TermTable = "CREATE TABLE IF NOT EXISTS Term_tbl(term_id INTEGER PRIMARY KEY, term_desc VARCHAR NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = TermTable;
                sqlite_cmd.ExecuteNonQuery();

                // User //
                string UserTable = "CREATE TABLE IF NOT EXISTS User_tbl(user_id INTEGER PRIMARY KEY AUTOINCREMENT, user_name VARCHAR NOT NULL UNIQUE, user_pass VARCHAR NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = UserTable;
                sqlite_cmd.ExecuteNonQuery();
            });
        }

        // Insert Student Data
        public void InsertStudentData(SQLiteConnection conn, long LRN, string fname, string midname, string surname, string section, int level)
        {//For testing only. We don't insert students, enrolment team does. Maybe we could ask JB for an API
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Student_tbl(student_lrn, first_name, middle_name, surname, section, level) VALUES (@lrn, @fname, @midname, @surname, @section, @level);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@lrn", LRN);
            sqlite_cmd.Parameters.AddWithValue("@fname", fname);
            sqlite_cmd.Parameters.AddWithValue("@midname", midname);
            sqlite_cmd.Parameters.AddWithValue("@surname", surname);
            sqlite_cmd.Parameters.AddWithValue("@section", section);
            sqlite_cmd.Parameters.AddWithValue("@level", level);

            sqlite_cmd.ExecuteNonQuery();
        }

        // Insert Transaction Data
        public void InsertTransaction(SQLiteConnection conn, int amount, string type, string sid, string receipt, int term)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Transaction_tbl(amount, type, student_id, receipt_number, term, date_recorded) VALUES (@amount, @type, @sid, @receipt, @term, @date_recorded);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            sqlite_cmd.Parameters.AddWithValue("@type", type);
            sqlite_cmd.Parameters.AddWithValue("@sid", sid);
            sqlite_cmd.Parameters.AddWithValue("@receipt", receipt);
            sqlite_cmd.Parameters.AddWithValue("@term", term);
            sqlite_cmd.Parameters.AddWithValue("@date_recorded", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        // Insert Term
        public async Task InsertTerm(SQLiteConnection conn, string termId, string termDesc)
        {
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;

                string insertData = "INSERT INTO Term_tbl(term_id, term_desc) VALUES (@term, @desc);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = insertData;

                sqlite_cmd.Parameters.AddWithValue("@term", termId); // id = 1 - infinity (incremental)
                sqlite_cmd.Parameters.AddWithValue("@desc", termDesc); // IsCurrent term

                sqlite_cmd.ExecuteNonQuery();
            });
        }

        // Get Term (made async to increase performance)
        public async Task GetTerm(SQLiteConnection conn, DataGridView dgv)
        {
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Term_tbl", conn);

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {
                    dgv.Rows.Clear();
                    while (read.Read())
                    {
                        dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // term id
                        read.GetValue(read.GetOrdinal("term_desc")), // term description
                    });
                    }
                }
            });
        }

        // Get Term (This is for StudentLedgerWindow)
        public async Task GetTerm(SQLiteConnection conn, ComboBox cb)
        {
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Term_tbl", conn);

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        cb.Items.Add(read.GetValue(read.GetOrdinal("term_desc"))); // term description
                    }
                }
            });
        }

        // Get Specific Student Transactions
        public void GetStudentTransactions(SQLiteConnection conn, DataGridView dgv, string sid)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From Transaction_tbl WHERE student_id = @sid", conn); //AND TERM = current term
            sqlite_cmd.Parameters.AddWithValue("@sid", sid);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("amount")), // amount
                        read.GetValue(read.GetOrdinal("type")), // type
                        read.GetValue(read.GetOrdinal("term")), // term
                        read.GetValue(read.GetOrdinal("receipt_number")), // receipt
                        read.GetValue(read.GetOrdinal("date_recorded"))
                    });
                }
            }
        }

        // Get All Student Transactions
        public void GetAllTransactions(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl", conn);
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            while (read.Read())
            {
                dgv.Rows.Add(new object[]
                {
                    read.GetValue(0),
                    read.GetValue(read.GetOrdinal("student_id")),
                    read.GetValue(read.GetOrdinal("type")),
                    read.GetValue(read.GetOrdinal("amount")),
                    read.GetValue(read.GetOrdinal("receipt_number")),
                    read.GetValue(read.GetOrdinal("term")),
                    read.GetValue(read.GetOrdinal("date_recorded"))
                });
            }
        }

        // Filters Transactions By Day
        public void FilterTransactionsByDay(SQLiteConnection conn, DataGridView dgv, string month, string day, string year)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl WHERE strftime('%m', date_recorded) = @month AND strftime('%d', date_recorded) = @day AND strftime('%Y', date_recorded) = @year", conn);
            sqlite_cmd.Parameters.AddWithValue("@month", month);
            sqlite_cmd.Parameters.AddWithValue("@day", day);
            sqlite_cmd.Parameters.AddWithValue("@year", year);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("student_id")),
                        read.GetValue(read.GetOrdinal("type")),
                        read.GetValue(read.GetOrdinal("amount")),
                        read.GetValue(read.GetOrdinal("receipt_number")),
                        read.GetValue(read.GetOrdinal("term")),
                        read.GetValue(read.GetOrdinal("date_recorded"))
                    });
                }
            }

        }

        // Filters Transaction By Month
        public void FilterTransactionsByMonth(SQLiteConnection conn, DataGridView dgv, string month, string year)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl WHERE strftime('%m', date_recorded) = @month AND strftime('%Y', date_recorded) = @year", conn);
            sqlite_cmd.Parameters.AddWithValue("@month", month);
            sqlite_cmd.Parameters.AddWithValue("@year", year);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("student_id")),
                        read.GetValue(read.GetOrdinal("type")),
                        read.GetValue(read.GetOrdinal("amount")),
                        read.GetValue(read.GetOrdinal("receipt_number")),
                        read.GetValue(read.GetOrdinal("term")),
                        read.GetValue(read.GetOrdinal("date_recorded"))
                    });
                }
            }
        }

        // Get Total Sum of amount by Month (For LiveCharts)
        public int GetTotalTransByMonthAsync(SQLiteConnection conn, string month, string year)
        {
            int result = 0;

            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl WHERE strftime('%m', date_recorded) = @month AND strftime('%Y', date_recorded) = @year", conn);
            sqlite_cmd.Parameters.AddWithValue("@month", month);
            sqlite_cmd.Parameters.AddWithValue("@year", year);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {

                while (read.Read())
                {
                    result += (int)read.GetValue(read.GetOrdinal("amount"));
                }
                return result;
            }
            //return result;
        }

        public async Task<string> GetTotalTransaction(SQLiteConnection conn)
        {
            return await Task.Run(() =>
            {
                int result = 0;

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl", conn);

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        result += (int)read.GetValue(read.GetOrdinal("amount"));
                    }
                    return result.ToString();
                }
            });   
        }

        // Get all user
        public async Task GetAllUsers(SQLiteConnection conn, DataGridView dgv)
        {
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = new SQLiteCommand("SELECT * FROM User_Tbl;", conn);

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {
                    dgv.Rows.Clear();
                    while (read.Read())
                    {
                        dgv.Rows.Add(new object[]
                        {
                            read.GetValue(0),
                            read.GetValue(read.GetOrdinal("user_name"))
                        });
                    }
                }
            }); 
        }

        // Add user
        public async Task InsertUserCreds(SQLiteConnection conn, string username, string password)
        {
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;

                string insertData = "INSERT INTO User_tbl(user_name, user_pass) VALUES (@uname, @upass);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = insertData;

                sqlite_cmd.Parameters.AddWithValue("@uname", username);
                sqlite_cmd.Parameters.AddWithValue("@upass", password);

                sqlite_cmd.ExecuteNonQuery();
            });
        }

        // For change password
        public void UpdateUserCreds(SQLiteConnection conn, string curr_uname, string curr_upass, string new_uname, string new_upass)
        {

            using (conn)
            using (var sqlite_cmd = new SQLiteCommand())
            {

                sqlite_cmd.Connection = conn;

                string IsUserExist = "SELECT count(*) FROM User_tbl WHERE user_name = @curr_uname AND user_pass = @curr_upass";
                string UpdateData = "UPDATE User_tbl SET user_name = @new_uname, user_pass = @new_upass WHERE user_name = @curr_uname AND user_pass = @curr_upass;";

                //sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = IsUserExist;


                sqlite_cmd.Parameters.AddWithValue("@curr_uname", curr_uname);
                sqlite_cmd.Parameters.AddWithValue("@curr_upass", curr_upass);

                var userCount = (long)sqlite_cmd.ExecuteScalar();
                if (userCount == 1)
                {
                    sqlite_cmd.CommandText = UpdateData;
                    sqlite_cmd.Parameters.AddWithValue("@new_uname", new_uname);
                    sqlite_cmd.Parameters.AddWithValue("@new_upass", new_upass);
                    var result = (Int32)sqlite_cmd.ExecuteNonQuery();
                    if (result == 1)
                    {
                        MessageBox.Show("Username and Password Updated Successfully! | Task Completed!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password | Incorrect details entered!");
                }
            }

            //sqlite_cmd.ExecuteNonQuery();
        }

        // Check if user exists.
        public async Task<bool> GetUserCreds(SQLiteConnection conn, string uname, string upass)
        {
            return await Task.Run(() =>
            {
                bool IsExist = false;

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = new SQLiteCommand("SELECT * FROM User_tbl WHERE user_name = @uname AND user_pass = @upass", conn);
                sqlite_cmd.Parameters.AddWithValue("@uname", uname);
                sqlite_cmd.Parameters.AddWithValue("@upass", upass);

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        IsExist = true;
                    }
                    return IsExist;
                }
            });
        }

        // Get userId 
        private int GetUserId(SQLiteConnection conn, string uname, string upass)
        {
            int result = 0;
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT user_id FROM User_tbl WHERE user_name = @uname AND user_pass = @upass", conn);
            sqlite_cmd.Parameters.AddWithValue("@uname", uname);
            sqlite_cmd.Parameters.AddWithValue("@upass", upass);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {

                while (read.Read())
                {
                    result = (int)read.GetValue(0);
                }
                return result;
            }
        }
    }
}
