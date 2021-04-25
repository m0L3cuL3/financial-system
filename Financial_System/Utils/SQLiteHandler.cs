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
        Globals gs = new Globals();

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
                string StudentTable = "CREATE TABLE IF NOT EXISTS Student_tbl(lrn BIGINT PRIMARY KEY, first_name VARCHAR, middle_name VARCHAR, surname VARCHAR NOT NULL, date_created DATE NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = StudentTable;
                sqlite_cmd.ExecuteNonQuery();

                // TRANSACTION // renamed by alexislyndon
                string TransactionTable = "CREATE TABLE IF NOT EXISTS Transaction_tbl(transaction_id INTEGER PRIMARY KEY AUTOINCREMENT, amount INT NULL, payment INT NULL , type VARCHAR NOT NULL, lrn INT NOT NULL, reference VARCHAR NOT NULL, term INT NOT NULL, date_recorded DATE NOT NULL, user INT NULL, void TINYINT NULL, FOREIGN KEY(lrn) REFERENCES Student_tbl(lrn), FOREIGN KEY(user) REFERENCES User_tbl(user_id));";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = TransactionTable;
                sqlite_cmd.ExecuteNonQuery();

                // TERM //
                string TermTable = "CREATE TABLE IF NOT EXISTS Term_tbl(term_id INTEGER PRIMARY KEY, term_desc VARCHAR NOT NULL, current TINYINT);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = TermTable;
                sqlite_cmd.ExecuteNonQuery();

                // User //
                string UserTable = "CREATE TABLE IF NOT EXISTS User_tbl(user_id INTEGER PRIMARY KEY AUTOINCREMENT, user_name VARCHAR NOT NULL UNIQUE, user_pass VARCHAR NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = UserTable;
                sqlite_cmd.ExecuteNonQuery();

                ///////////////////// DB by alexislyndon tables added: Enrolment_tbl, Fees_tbl, FeeGroup_tbl, Orphans_tbl

                string EnrolmentTable = "CREATE TABLE IF NOT EXISTS Enrolment_tbl(enrolment_id INTEGER PRIMARY KEY AUTOINCREMENT, lrn INT NOT NULL UNIQUE, first_name VARCHAR NOT NULL, middle_name VARCHAR, surname VARCHAR NOT NULL, section VARCHAR NOT NULL, level INT NOT NULL, aycode INT NOT NULL, FOREIGN KEY(aycode) REFERENCES Term_tbl(term_id) ON UPDATE CASCADE, FOREIGN KEY(lrn) REFERENCES Student_tbl(lrn) ON UPDATE CASCADE );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = EnrolmentTable;
                sqlite_cmd.ExecuteNonQuery();

                // Schedule of Fees Table AKA Particulars// increases/decrease balance
                string ScheduleFeesPayments = "CREATE TABLE IF NOT EXISTS FPTemplate_tbl(fp_id INTEGER PRIMARY KEY AUTOINCREMENT, fp_name VARCHAR NOT NULL UNIQUE, amount INT, payment INT, fp_desc VARCHAR NOT NULL);";
                sqlite_cmd = conn.CreateCommand();                        //Fee or Payment Template table
                sqlite_cmd.CommandText = ScheduleFeesPayments;
                sqlite_cmd.ExecuteNonQuery();

                // Fee or Payment Group //
                string FeeGroupTable = "CREATE TABLE IF NOT EXISTS FeeGroup_tbl(fg_id INTEGER PRIMARY KEY AUTOINCREMENT, fg_name VARCHAR NOT NULL, fg_desc VARCHAR NOT NULL, date_recorded DATE NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = FeeGroupTable;
                sqlite_cmd.ExecuteNonQuery();

                //list of fees in a FeeGroup
                string FeeGroupFeesTable = "CREATE TABLE IF NOT EXISTS FeeGroupFees_tbl(fg_id INTEGER, fp_id INT NOT NULL, FOREIGN KEY(fg_id) REFERENCES FeeGroup_tbl(fg_id) ON DELETE CASCADE, FOREIGN KEY(fp_id) REFERENCES FPTemplate_tbl(fp_id) ON DELETE CASCADE );"; //ON DELETE CASCADE
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = FeeGroupFeesTable;
                sqlite_cmd.ExecuteNonQuery();

                //List of students
                string CustomStudentListTable = "CREATE TABLE IF NOT EXISTS CustomStudentList_tbl(list_id INTEGER PRIMARY KEY AUTOINCREMENT, list_name VARCHAR NOT NULL, list_desc VARCHAR NOT NULL);"; //ON DELETE CASCADE
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = CustomStudentListTable;
                sqlite_cmd.ExecuteNonQuery();

                //LRNs in a List 
                string CustomStudentListMembersTable = "CREATE TABLE IF NOT EXISTS CustomStudentListMembers_tbl(list_id INTEGER NOT NULL, lrn INT NOT NULL, FOREIGN KEY(lrn) REFERENCES Student_tbl(lrn) ON DELETE CASCADE, FOREIGN KEY(list_id) REFERENCES CustomStudentList(list_id) ON DELETE CASCADE );"; //ON DELETE CASCADE
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = CustomStudentListMembersTable;
                sqlite_cmd.ExecuteNonQuery();

                /*// Transactions without an enrolment id //
                string OrphanTransactions = "CREATE TABLE IF NOT EXISTS OrphanTransactions_tbl(id INTEGER PRIMARY KEY AUTOINCREMENT, tid INT NOT NULL, lrn VARCHAR NOT NULL, resolved? VARCHAR);"; //Learner Reference Number: 12digit unique nationwide
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = OrphanTransactions;
                sqlite_cmd.ExecuteNonQuery();*/
            });
        }

        public async Task CreateParticulars(SQLiteConnection conn)
        {
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;
                SQLiteCommand sqlite_cmd2;
                string discounts = "INSERT INTO FPTemplate_tbl(fp_name, fp_desc, payment) VALUES ('JUNIOR Full Scholarship', 'Grade 7 - Grade 10 Full Amount', '12000')," +
                "('SHS Full Scholarship', 'Grade 11 - Grade 12 Full Amount', '17000')," +
                "('JUNIOR Tuition only Discount', 'Grade 7 - Grade 10 Tuition Only', '6790')," +
                "('SHS Tuition only Discount', 'Grade 11 - Grade 12 Tuition Only', '11790');";
                sqlite_cmd2 = conn.CreateCommand();
                sqlite_cmd2.CommandText = discounts;


                string Fees = "INSERT INTO FPTemplate_tbl(fp_name, fp_desc, amount) VALUES ('Junior Tuition Fee', 'Grade 7 - Grade 10 Tuition Fee', '6790' )," +
                "('SHS Tuition Fee', 'Grade 11 - Grade 10 Tuition Fee', '11790' )," +
                "('Testing', 'Testing Fee - all Levels', '300' )," +
                "('Library', 'Library Fee - all levels', '200' )," +
                "('Computer', 'Computer Fee - all levels', '400' )," +
                "('Science Lab', 'Science Lab Fee - all levels', '100' )," +
                "('TLE/Horti Lab', 'TLE/Horti Lab - all levels', '300' )," +
                "('Athletics', 'Athletics Fee - all levels', '280' )," +
                "('Cultural Fee', 'Cultural Fee - all levels', '100' )," +
                "('Medical/Dental', 'Medical/Dental Services Fee', '500' )," +
                "('Security Fee', 'Security Guard', '250' )," +
                "('Band Support', 'Band Support Fee', '100' )," +
                "('SSC', 'SSC', '100' )," +
                "('Guidance Fee', 'Guidance Fee - all levels', '100' )," +
                "('Campus Ministry', 'Campus Ministry - all levels', '100' )," +
                "('Ceap Due', 'Ceap Due', '50' )," +
                "('Student Handbook', 'Student Handbook - all levels', '80' )," +
                "('ID Fee', 'Identification Card Fee - all levels', '150' )," +
                "('Student Publication', 'Student Publication - all levels', '100' )," +
                "('Test Permit Card', 'Test Permit Card Fee - all levels', '50' )," +
                "('Energy Fee', 'Energy Fee - all levels', '200' )," +
                "('Activity Fee', 'Activity Fee - all levels', '100' )," +
                "('Facilities Development Fee', 'Facilities Development Fee - all levels', '1000' )," +
                "('Faculty Development', 'Faculty Development - all levels', '250' )," +
                "('Buacs & Ceap M', 'Buacs & Ceap M', '100' )," +
                "('SWF Insurance', 'SWF Insurance', '100' )," +
                "('PTA', 'PTA', '200' );";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = Fees;

                try
                {
                    sqlite_cmd.ExecuteNonQuery();
                    sqlite_cmd2.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Particulars Already in Database!");
                }
            });
            
        }

        // Insert Student Data
        public void InsertStudentData(SQLiteConnection conn, long LRN, string fname, string midname, string surname)
        {//For testing only. We don't insert students, enrolment team does. Maybe we could ask JB for an API
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Student_tbl(lrn, first_name, middle_name, surname, date_created) VALUES (@lrn, @fname, @midname, @surname, @date);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@lrn", LRN);
            sqlite_cmd.Parameters.AddWithValue("@fname", fname);
            sqlite_cmd.Parameters.AddWithValue("@midname", midname);
            sqlite_cmd.Parameters.AddWithValue("@surname", surname);
            //sqlite_cmd.Parameters.AddWithValue("@section", section);
            //sqlite_cmd.Parameters.AddWithValue("@level", level);
            sqlite_cmd.Parameters.AddWithValue("@date", DateTime.Now);


            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertImportData(SQLiteConnection conn, long LRN, string fname, string midname, string surname, string section, int level, string aycode)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Enrolment_tbl(lrn, first_name, middle_name, surname, section, level, aycode) VALUES (@lrn, @fname, @midname, @surname, @section, @level, @aycode);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@lrn", LRN);
            sqlite_cmd.Parameters.AddWithValue("@fname", fname);
            sqlite_cmd.Parameters.AddWithValue("@midname", midname);
            sqlite_cmd.Parameters.AddWithValue("@surname", surname);
            sqlite_cmd.Parameters.AddWithValue("@section", section);
            sqlite_cmd.Parameters.AddWithValue("@level", level);
            sqlite_cmd.Parameters.AddWithValue("@aycode", aycode);

            sqlite_cmd.ExecuteNonQuery();
        }

        public async Task<string> GetStudentCount(SQLiteConnection conn)
        {
            return await Task.Run(() =>
            {
                object result;

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = new SQLiteCommand("SELECT Count(*) FROM Student_tbl", conn);

                result = sqlite_cmd.ExecuteScalar();

                int numRows = Convert.ToInt32(result);

                return numRows.ToString();
            });
        } //CountCurrentTerm

        // // ///
        public int CountCurrentTerm(SQLiteConnection conn)
        {
                object result;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = new SQLiteCommand("SELECT Count(*) FROM Term_tbl WHERE current = 1", conn);
                result = sqlite_cmd.ExecuteScalar();
                int numRows = Convert.ToInt32(result);

                return numRows;
        } //CountCurrentTerm
        // // ///




        /// <summary>
        /// Post a transaction tied to a student by its lrn
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="amount"></param>
        /// <param name="payment"></param>
        /// <param name="type"></param>
        /// <param name="lrn"></param>
        /// <param name="reference"></param>
        public void InsertTransaction(SQLiteConnection conn, int? amount, int? payment, string type, string lrn, string reference)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Transaction_tbl(amount, payment, type, lrn, reference, date_recorded, term) VALUES (@amount, @payment, @type, @lrn, @ref, @date_recorded, @term);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            sqlite_cmd.Parameters.AddWithValue("@payment", payment);
            sqlite_cmd.Parameters.AddWithValue("@type", type);
            sqlite_cmd.Parameters.AddWithValue("@lrn", lrn);
            sqlite_cmd.Parameters.AddWithValue("@ref", reference);
            sqlite_cmd.Parameters.AddWithValue("@term", Globals._term.ToString());
            sqlite_cmd.Parameters.AddWithValue("@date_recorded", DateTime.Now);
            //MessageBox.Show(Globals._term.ToString());

            sqlite_cmd.ExecuteNonQuery();
        }

        // Insert Term
        public async Task InsertTerm(SQLiteConnection conn, string termId, string termDesc, bool current) 
        {
            if (current) {
                SQLiteCommand sqlite_cmd;
                string SetalltoFalse = "UPDATE Term_tbl SET current = 0";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = SetalltoFalse;
                sqlite_cmd.ExecuteNonQuery();
            }

            int testInt = current ? 1 : 0;
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;

                string insertData = "INSERT INTO Term_tbl(term_id, term_desc, current) VALUES (@term, @desc, @current);"; //
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = insertData;

                sqlite_cmd.Parameters.AddWithValue("@term", termId); // id = 1 - infinity (incremental)
                sqlite_cmd.Parameters.AddWithValue("@desc", termDesc); // could contain date start end 
                sqlite_cmd.Parameters.AddWithValue("@current", testInt); // IsCurrent term TINY INT 1 OR 0 /// 1 means current


                sqlite_cmd.ExecuteNonQuery();
            });
        }

        //WIP
        public async Task UpdateTerm(SQLiteConnection conn, string termId, string termDesc, bool current)
        {
            if (current)
            {
                SQLiteCommand sqlite_cmd;
                string SetalltoFalse = "UPDATE Term_tbl SET current = 0";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = SetalltoFalse;
                sqlite_cmd.ExecuteNonQuery();
            }

            int testInt = current ? 1 : 0;
            await Task.Run(() =>
            {
                SQLiteCommand sqlite_cmd;

                string insertData = "UPDATE Term_tbl SET term_id = @term, term_desc = @desc, current = @current WHERE term_id = @term ;";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = insertData;

                sqlite_cmd.Parameters.AddWithValue("@term", termId); // id = 1 - infinity (incremental)
                sqlite_cmd.Parameters.AddWithValue("@desc", termDesc); // could contain date start end 
                sqlite_cmd.Parameters.AddWithValue("@current", testInt); // IsCurrent term TINY INT 1 OR 0 /// 1 means current


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

                string tf = "";

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {
                    dgv.Rows.Clear();
                    while (read.Read())
                    {
                        if (read.GetValue(2).ToString() == "1") { tf = "True"; } else { tf = "False"; }

                        dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // term id
                        read.GetValue(read.GetOrdinal("term_desc")), // term description
                        tf
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

        public List<string> GetTerm(SQLiteConnection conn, string termid)
        {
            List<string> list = new List<string>();
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("SELECT * FROM Term_tbl WHERE term_id = @term", conn);
            sqlite_cmd.Parameters.AddWithValue("@term", termid); // id = 1 - infinity (incremental)

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    list.Add(read.GetValue(0).ToString());
                    list.Add(read.GetValue(1).ToString());
                    list.Add(read.GetValue(2).ToString());

                }
            }
            return list;
        }

        public void TermMakeCurrent(SQLiteConnection conn, string termid) 
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("UPDATE Term_tbl SET current = 0", conn); //AND TERM = current term
            sqlite_cmd.ExecuteNonQuery();

        }

        // Get Specific Student Transactions
        // TO CHANGE GET TRANSACTION ON LRN ON CURRENT TERM
        public void GetStudentTransactions(SQLiteConnection conn, DataGridView dgv, string lrn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From Transaction_tbl WHERE lrn = @lrn", conn); //AND TERM = current term
            sqlite_cmd.Parameters.AddWithValue("@lrn", lrn);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("amount")), // amount
                        read.GetValue(read.GetOrdinal("payment")), // payment
                        read.GetValue(read.GetOrdinal("type")), // type
                        read.GetValue(read.GetOrdinal("term")),
                        read.GetValue(read.GetOrdinal("reference")), // receipt
                        read.GetValue(read.GetOrdinal("date_recorded"))
                    });
                    //MessageBox.Show(read.GetValue(read.GetOrdinal("term")).ToString());

                }
            }
        }

        // Get All Student Transactions
        public void GetAllTransactions(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl", conn); // WHERE payment > 0
            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            while (read.Read())
            {
                dgv.Rows.Add(new object[]
                {
                    read.GetValue(0),
                    read.GetValue(read.GetOrdinal("lrn")),
                    read.GetValue(read.GetOrdinal("type")),
                    read.GetValue(read.GetOrdinal("payment")),
                    read.GetValue(read.GetOrdinal("reference")),
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
                        read.GetValue(read.GetOrdinal("lrn")),
                        read.GetValue(read.GetOrdinal("type")),
                        read.GetValue(read.GetOrdinal("payment")),
                        read.GetValue(read.GetOrdinal("reference")),
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
                        read.GetValue(read.GetOrdinal("lrn")),
                        read.GetValue(read.GetOrdinal("type")),
                        read.GetValue(read.GetOrdinal("payment")),
                        read.GetValue(read.GetOrdinal("reference")),
                        read.GetValue(read.GetOrdinal("term")),
                        read.GetValue(read.GetOrdinal("date_recorded"))
                    });
                }
            }
        }

        // Get Total Sum of amount by Month (For LiveCharts)
        public int GetTotalTransByMonth(SQLiteConnection conn, string month, string year)
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
                    result += (int)read.GetValue(read.GetOrdinal("payment"));
                }
                return result;
            }
            //return result;
        }

        public async Task<string> GetTotalTransaction(SQLiteConnection conn, string year)
        {
            return await Task.Run(() =>
            {
                int result = 0;

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Transaction_tbl WHERE strftime('%Y', date_recorded) = @year", conn);
                sqlite_cmd.Parameters.AddWithValue("@year", year);

                using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
                {

                    while (read.Read())
                    {
                        result += read.GetInt32(read.GetOrdinal("payment")).Equals(DBNull.Value) ? 0 : read.GetInt32(read.GetOrdinal("payment"));
                    }
                    return result.ToString();
                }
            });   
        }

        public async Task<string> GetTransactionCount(SQLiteConnection conn)
        {
            return await Task.Run(() =>
            {
                object result;

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = new SQLiteCommand("SELECT Count(*) FROM Transaction_tbl", conn);

                result = sqlite_cmd.ExecuteScalar();

                int numRows = Convert.ToInt32(result);

                return numRows.ToString();
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

                try
                {
                    sqlite_cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Duplicate Username! \n \n Please use a different username from the ones already in the list.");
                }
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

        /// <summary>
        /// Creates a new Fee Template for use in bulk operations. Fees increase the balance. Fees are charges by the school to the student.
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="amount"></param>
        public void NewFeeTemplate(SQLiteConnection conn, string name, string desc, int amount)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO FPTemplate_tbl(fp_name, fp_desc, amount) VALUES (@name, @desc, @amount);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            //sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@desc", desc);
            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            //sqlite_cmd.Parameters.AddWithValue("@date_recorded", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Creates a new Payment Template for use in bulk operations. Payments decrease the balance. For the purpose of decreasing the student's balance, discounts, scholarships can also be applied as a payment transaction.
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="payment"></param>
        public void NewPaymentTemplate(SQLiteConnection conn, string name, string desc, int payment)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO FPTemplate_tbl(fp_name, fp_desc, payment) VALUES (@name, @desc, @payment);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            //sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@desc", desc);
            sqlite_cmd.Parameters.AddWithValue("@payment", payment);
            //sqlite_cmd.Parameters.AddWithValue("@date_recorded", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        // adds a fee or payment into a fee group
        public void InsertFeeTOGroup(SQLiteConnection conn, string feegroupID, string feepayment)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO FeeGroupFees_tbl(fg_id, fp_id) VALUES (@fgid, @fpid);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fgid", feegroupID);
            sqlite_cmd.Parameters.AddWithValue("@fpid", feepayment);
            //sqlite_cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void DELETEFeeFROMGroup(SQLiteConnection conn, string feegroupID, string feepayment)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "DELETE FROM FeeGroupFees_tbl WHERE fg_id = @fgid  AND fp_id = @fpid;";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fgid", feegroupID);
            sqlite_cmd.Parameters.AddWithValue("@fpid", feepayment);
            //sqlite_cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        // this function takes a list of LRNs and executes the fee group against them
        public void ExecuteFeeGroup(SQLiteConnection conn, int feegroupID, List<string> lrns)
        {
            try
            {
                List<int> feegroupfees = new List<int>();
                feegroupfees.AddRange(GetFeeGroupFees(conn, feegroupID)); // a list of all the fees in a group
                var feegroupname = GetFeeGroupname(conn, feegroupID);

                foreach (string student in lrns) // for every lrn in the list
                {
                    foreach (int fee in feegroupfees) // for every fee in a feegroup 
                    {
                        List<string> feedetails = GetFeesPayments(conn, fee);
                        string fid = feedetails[0]; //feepayment_id
                        string name = feedetails[1]; //name
                        string desc = feedetails[4]; //desc
                        string amount = feedetails[2]; //amount
                        string payment = feedetails[3]; //payment

                        //MessageBox.Show($"FEE ID: {fid}\n NAME: {name}\n DESC: {desc}\n AMOUNT: {amount}\n PAYMENT: {payment}", "Fee Group", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        InsertTransaction(conn, amount.Equals("") ? 0 : Convert.ToInt32(amount), payment.Equals("") ? 0 : Convert.ToInt32(payment), name, student.ToString(), feegroupname);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // referenced by ExecuteFeeGroup()
        public List<int> GetFeeGroupFees(SQLiteConnection conn, int feegroupID)
        {
            List<int> feesinagroup = new List<int>();

            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM FeeGroupFees_tbl WHERE fg_id = @feegroupiD", conn);
            sqlite_cmd.Parameters.AddWithValue("@feegroupID", feegroupID);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    feesinagroup.Add((int)read.GetValue(1));
                }
                return feesinagroup; //returns the fees in a FeeGroup
            }
        }

        public void GetFeeGroupFeesMembers(SQLiteConnection conn, string feegroupID, DataGridView dgv) //called by datagridview4 when selection changes to populate datagridview3
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("SELECT * FROM FeeGroupFees_tbl WHERE fg_id = @fg_id", conn);
            sqlite_cmd.Parameters.AddWithValue("@fg_id", feegroupID);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    GetFeesPaymentstoDGV(conn, read.GetValue(1).ToString(), dgv);
                }
            }
        }

        //gets the details of a Fee or Payment : fp_id name desc amount payment
        public List<string> GetFeesPayments(SQLiteConnection conn, int fp_id)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From FPTemplate_tbl WHERE fp_id = @fpid", conn); //AND TERM = current term
            sqlite_cmd.Parameters.AddWithValue("@fpid", fp_id);
            List<string> fp = new List<string>();

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    fp.Add(read.GetValue(0).ToString()); //feepayment_id
                    fp.Add(read.GetValue(1).ToString()); //name
                    fp.Add(read.GetValue(2).ToString()); //desc
                    fp.Add(read.GetValue(3).ToString()); //amount
                    fp.Add(read.GetValue(4).ToString()); //payment
                    //read.GetValue(read.GetOrdinal("amount"))

                }

                return fp; // returns details of a payment/fee in a form of List
            }
        }

        // // // 
        public List<string> GetFGroup(SQLiteConnection conn, int fg_id)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From FeeGroup_tbl WHERE fg_id = @fgid", conn);
            sqlite_cmd.Parameters.AddWithValue("@fgid", fg_id);
            List<string> fg = new List<string>();

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    fg.Add(read.GetValue(0).ToString()); //Group_id
                    fg.Add(read.GetValue(1).ToString()); //name
                    fg.Add(read.GetValue(2).ToString()); //desc
                }

                return fg; // returns details of a payment/fee in a form of List
            }
        }
        // // //


        public void GetFeesPaymentstoDGV(SQLiteConnection conn, string fp_id, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From FPTemplate_tbl WHERE fp_id = @fpid", conn);
            sqlite_cmd.Parameters.AddWithValue("@fpid", fp_id);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // fp_id
                        read.GetValue(read.GetOrdinal("fp_name")), // fee or payment name
                        read.GetValue(read.GetOrdinal("payment")), // amount (balance increasing)
                        read.GetValue(read.GetOrdinal("amount")) // amount (balance increasing)
                });
                }
            }
        }

        /// <summary>
        /// Returns the name of a Fee Group
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="feegroupID"></param>
        /// <returns></returns>
        public string GetFeeGroupname(SQLiteConnection conn, int feegroupID)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM FeeGroup_tbl WHERE fg_id = @feegroupiD", conn);
            sqlite_cmd.Parameters.AddWithValue("@feegroupID", feegroupID);
            var feegroupname = "";

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    feegroupname = read.GetValue(read.GetOrdinal("fg_name")).ToString();
                }
            }
            return feegroupname;
        }

        public void GetFees(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From FPTemplate_tbl WHERE amount IS NOT NULL", conn);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("fp_name")), // fee or payment name
                        //read.GetValue(read.GetOrdinal("fp_desc")), // desc
                        read.GetValue(read.GetOrdinal("amount")), // amount (balance increasing)
                        //read.GetValue(read.GetOrdinal("fg_name")).ToString();
                });
                }
            }
        }

        // ///////// // // ////
        public int GetCurrentTerm(SQLiteConnection conn)
        {
            int tt = -1;

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("SELECT * FROM Term_tbl WHERE current = 1", conn);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    tt = (int)read.GetInt32(0);
                }
            }
            //MessageBox.Show(tt.ToString()); // shows the current term id
            return tt;
        }
        // ////////

        public void GetPayments(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From FPTemplate_tbl WHERE payment IS NOT NULL", conn);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("fp_name")), // fee or payment name
                        //read.GetValue(read.GetOrdinal("fp_desc")), // desc
                        read.GetValue(read.GetOrdinal("payment")), // payment (balance decreasing)
                        //read.GetValue(read.GetOrdinal("fg_name")).ToString();
                });
                }
            }
        } 
        
        //NewGroup
        public void NewGroup(SQLiteConnection conn, string name, string desc)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO FeeGroup_tbl(fg_name, fg_desc, date_recorded) VALUES (@name, @desc, @date_recorded);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            //sqlite_cmd.Parameters.AddWithValue("@id", id);
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@desc", desc);
            sqlite_cmd.Parameters.AddWithValue("@date_recorded", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void GetGroups(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From FeeGroup_tbl", conn);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("fg_name")), // fee or payment name
                        read.GetValue(read.GetOrdinal("fg_desc")), // desc
                        //read.GetValue(read.GetOrdinal("amount")), // amount (balance increasing)
                        //read.GetValue(read.GetOrdinal("fg_name")).ToString();
                });
                }
            }
        }

        /// <summary>
        /// Update Fee or Payment. Set amound or payment params to null if not applicable
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="feeid"></param>
        /// <param name="name"></param>
        /// <param name="desc"></param>
        /// <param name="amount"></param>
        /// <param name="payment"></param>
        public void UpdateFP(SQLiteConnection conn, string feeid , string name, string desc, int? amount, int? payment )
        {
            if (amount == null) // payment
            {
                SQLiteCommand sqlite_cmd;
                string UpdatePayment = "UPDATE FPTemplate_tbl SET fp_name = @name, fp_desc = @desc, payment = @payment WHERE fp_id = @id";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = UpdatePayment;

                sqlite_cmd.Parameters.AddWithValue("@id", feeid); // 
                sqlite_cmd.Parameters.AddWithValue("@desc", desc); // 
                sqlite_cmd.Parameters.AddWithValue("@name", name); // 
                sqlite_cmd.Parameters.AddWithValue("@payment", payment); // 

                sqlite_cmd.ExecuteNonQuery();
            }
            else if (payment == null) //fee
            {
                SQLiteCommand sqlite_cmd;
                string UpdateFee = "UPDATE FPTemplate_tbl SET fp_name = @name, fp_desc = @desc, amount = @amount WHERE fp_id = @id";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = UpdateFee;

                sqlite_cmd.Parameters.AddWithValue("@id", feeid); // 
                sqlite_cmd.Parameters.AddWithValue("@desc", desc); // 
                sqlite_cmd.Parameters.AddWithValue("@name", name); // 
                sqlite_cmd.Parameters.AddWithValue("@amount", amount); // 

                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void DeleteFP(SQLiteConnection conn, string feeid)
        {
                SQLiteCommand sqlite_cmd;

                string insertData = "DELETE FROM FPTemplate_tbl WHERE fp_id = @fpid;";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = insertData;

                sqlite_cmd.Parameters.AddWithValue("@fpid", feeid);
                //sqlite_cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

                sqlite_cmd.ExecuteNonQuery();
        }





        // // // // // 
        public void UpdateFPGroup(SQLiteConnection conn, string feegroupid, string name, string desc)
        {
                SQLiteCommand sqlite_cmd;
                string UpdatePayment = "UPDATE FeeGroup_tbl SET fg_name = @name, fg_desc = @desc WHERE fg_id = @id";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = UpdatePayment;

                sqlite_cmd.Parameters.AddWithValue("@id", feegroupid); // 
                sqlite_cmd.Parameters.AddWithValue("@desc", desc); // 
                sqlite_cmd.Parameters.AddWithValue("@name", name); // 

                sqlite_cmd.ExecuteNonQuery();
        }

        public void DeleteFPGroup(SQLiteConnection conn, string feegroupid)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "DELETE FROM FeeGroup_tbl WHERE fg_id = @fpid;";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fpid", feegroupid);
            //sqlite_cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }
        // // // // // 



        public void GetStudents(SQLiteConnection conn, DataGridView dgv, bool enrolledonly)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From Enrolment_tbl WHERE aycode = @term", conn); //AND TERM = current term
            sqlite_cmd.Parameters.AddWithValue("@term", Globals._term.ToString());

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("surname")), // amount
                        read.GetValue(read.GetOrdinal("first_name")), // payment
                        read.GetValue(read.GetOrdinal("middle_name")), // type
                        read.GetValue(read.GetOrdinal("level")), // type
                        read.GetValue(read.GetOrdinal("section")), // type

                    });
                }
            }
        }

        public void FilterStudentsBySurname(SQLiteConnection conn, DataGridView dgv, string familyname)
        {
            string family = "%" + familyname  + "%";

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl WHERE surname LIKE IIF(IFNULL(@surname, '') = '', surname, @surname)", conn);
            //sqlite_cmd.Parameters.AddWithValue("@lrn", lrn); // 
            //sqlite_cmd.Parameters.AddWithValue("@desc", middlename); // 
            //sqlite_cmd.Parameters.AddWithValue("@name", familyname); // 
            sqlite_cmd.Parameters.AddWithValue("@surname", family); // 

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  
                        read.GetValue(read.GetOrdinal("surname")), 
                        read.GetValue(read.GetOrdinal("first_name")), 
                        read.GetValue(read.GetOrdinal("middle_name")), 
                    });
                }
            }
        }

        public void FilterStudentsByLRN(SQLiteConnection conn, DataGridView dgv, string lrn)
        {
            string id = "%" + lrn + "%";

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student_tbl WHERE lrn LIKE IIF(IFNULL(@lrn, '') = '', lrn, @lrn)", conn);
            //sqlite_cmd.Parameters.AddWithValue("@lrn", lrn); // 
            //sqlite_cmd.Parameters.AddWithValue("@desc", middlename); // 
            //sqlite_cmd.Parameters.AddWithValue("@name", familyname); // 
            sqlite_cmd.Parameters.AddWithValue("@lrn", id); // 

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(read.GetOrdinal("surname")),
                        read.GetValue(read.GetOrdinal("first_name")),
                        read.GetValue(read.GetOrdinal("middle_name")),
                    });
                }
            }
        }

        public void InsertNewList(SQLiteConnection conn, string name, string desc, string listid)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO CustomStudentList_tbl(list_id, list_name, list_desc) VALUES (@id,@name, @desc);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@id", listid);
            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@desc", desc);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertLRNTOList(SQLiteConnection conn, List<string> lrns, string listid)
        {
            foreach (var item in lrns)
            {
                SQLiteCommand sqlite_cmd;

                string insertData = "INSERT INTO CustomStudentListMembers_tbl(list_id, lrn) VALUES (@listid, @lrn);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = insertData;

                sqlite_cmd.Parameters.AddWithValue("@listid", listid);
                sqlite_cmd.Parameters.AddWithValue("@lrn", item);

                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public int GetListCount(SQLiteConnection conn)
        {
                object result;

                SQLiteCommand sqlite_cmd;

                sqlite_cmd = new SQLiteCommand("SELECT Count(*) FROM CustomStudentList_tbl", conn);

                result = sqlite_cmd.ExecuteScalar();

                int numRows = Convert.ToInt32(result);

                return numRows;
        }

        public void GetLists(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From CustomStudentList_tbl", conn);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                dgv.Rows.Clear();
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // tid
                        read.GetValue(read.GetOrdinal("list_name")), // fee or payment name
                        read.GetValue(read.GetOrdinal("list_desc")), // desc
                        //read.GetValue(read.GetOrdinal("amount")), // amount (balance increasing)
                        //read.GetValue(read.GetOrdinal("fg_name")).ToString();
                });
                }
            }
        }

        //get all LRNs in a list
        public List<string> GetListsMembers(SQLiteConnection conn, string listid)
        {
            List<string> list = new List<string>();

            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("SELECT * FROM CustomStudentListMembers_tbl WHERE list_id = @listid", conn);
            sqlite_cmd.Parameters.AddWithValue("@listid", listid);

            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    list.Add(read.GetInt32(1).ToString());
                }
            }
            return list;
        }
    }
}
