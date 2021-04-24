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
                string StudentTable = "CREATE TABLE IF NOT EXISTS Student_tbl(lrn INTEGER PRIMARY KEY, first_name VARCHAR, middle_name VARCHAR, surname VARCHAR NOT NULL, date_created DATE NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = StudentTable;
                sqlite_cmd.ExecuteNonQuery();

                // TRANSACTION // renamed by alexislyndon
                string TransactionTable = "CREATE TABLE IF NOT EXISTS Transaction_tbl(transaction_id INTEGER PRIMARY KEY AUTOINCREMENT, amount INT NOT NULL, type VARCHAR NOT NULL, lrn INT NOT NULL, reference VARCHAR NOT NULL, date_recorded DATE NOT NULL, user INT NULL, void TINYINT NULL, FOREIGN KEY(lrn) REFERENCES Student_tbl(lrn), FOREIGN KEY(user) REFERENCES User_tbl(user_id));";
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

                ///////////////////// DB by alexislyndon tables added: Enrolment_tbl, Fees_tbl, FeeGroup_tbl, Orphans_tbl

                string EnrolmentTable = "CREATE TABLE IF NOT EXISTS Enrolment_tbl(enrolment_id INTEGER PRIMARY KEY, lrn INT NOT NULL UNIQUE, first_name VARCHAR NOT NULL, middle_name VARCHAR, surname VARCHAR NOT NULL, section VARCHAR NOT NULL, level INT NOT NULL, aycode VARCHAR);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = EnrolmentTable;
                sqlite_cmd.ExecuteNonQuery();

                // Schedule of Fees Table// increases/decrease balance
                string ScheduleFeesPayments = "CREATE TABLE IF NOT EXISTS FPTemplate_tbl(fp_id INTEGER PRIMARY KEY AUTOINCREMENT, fp_name  VARCHAR NOT NULL UNIQUE, amount INT, payment INT, fp_desc  VARCHAR NOT NULL);";
                sqlite_cmd = conn.CreateCommand();                        //Fee or Payment Template table
                sqlite_cmd.CommandText = ScheduleFeesPayments;
                sqlite_cmd.ExecuteNonQuery();

                // Fee or Payment Group //
                string FeeGroupTable = "CREATE TABLE IF NOT EXISTS FeeGroup_tbl(fg_id INTEGER PRIMARY KEY AUTOINCREMENT, fg_name VARCHAR NOT NULL, fg_desc VARCHAR NOT NULL, date_recorded DATE NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = FeeGroupTable;
                sqlite_cmd.ExecuteNonQuery();

                //list of fees in a FeeGroup
                string FeeGroupFeesTable = "CREATE TABLE IF NOT EXISTS FeeGroupFees_tbl(fg_id INTEGER PRIMARY KEY AUTOINCREMENT, fp_id INT NOT NULL);";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = FeeGroupFeesTable;
                sqlite_cmd.ExecuteNonQuery();

                /*// Transactions without an enrolment id //
                string OrphanTransactions = "CREATE TABLE IF NOT EXISTS OrphanTransactions_tbl(id INTEGER PRIMARY KEY AUTOINCREMENT, tid INT NOT NULL, lrn VARCHAR NOT NULL, resolved? VARCHAR);"; //Learner Reference Number: 12digit unique nationwide
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = OrphanTransactions;
                sqlite_cmd.ExecuteNonQuery();*/
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
        }

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

            string insertData = "INSERT INTO Transaction_tbl(amount, payment, type, lrn, reference, date_recorded) VALUES (@amount, @payment @type, @lrn, @ref, @date_recorded);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            sqlite_cmd.Parameters.AddWithValue("@payment", payment);
            sqlite_cmd.Parameters.AddWithValue("@type", type);
            sqlite_cmd.Parameters.AddWithValue("@lrn", lrn);
            sqlite_cmd.Parameters.AddWithValue("@ref", reference);
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
        // TO CHANGE GET TRANSACTION ON LRN ON CURRENT TERM
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
                    result += (int)read.GetValue(read.GetOrdinal("amount"));
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
                        result += (int)read.GetValue(read.GetOrdinal("amount"));
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

        /// <summary>
        /// Creates a new Fee Template for use in bulk operations. Fees increase the balance. Fees are charges by the school to the student.
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="id"></param>
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
        /// <param name="id"></param>
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

        //creates a new fee group
        public void NewFeeGroup(SQLiteConnection conn, string name, string desc)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO FeeGroup_tbl(fg_name, fg_desc, date_created) VALUES (@fgname, @fgdesc, @date_created);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@name", name);
            sqlite_cmd.Parameters.AddWithValue("@desc", desc);
            sqlite_cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        // adds a fee or payment into a fee group
        public void InsertFeeTOGroup(SQLiteConnection conn, int feegroupID, int feepayment)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO FeeGroupFees_tbl(fg_id, fp_id) VALUES (@fgid, @fpid);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fgid", feegroupID);
            sqlite_cmd.Parameters.AddWithValue("@desc", feepayment);
            //sqlite_cmd.Parameters.AddWithValue("@date_created", DateTime.Now);

            sqlite_cmd.ExecuteNonQuery();
        }

        // this function takes a list of LRNs and executes the fee group against them
        public void ExecuteFeeGroup(SQLiteConnection conn, int feegroupID, List<int> lrns)
        {
            List <int> feegroupfees = new List<int>();
            feegroupfees.AddRange(GetFeeGroupFees(conn, feegroupID)); // a list of all the fees in a group
            var feegroupname = GetFeeGroupname(conn, feegroupID);

            foreach (int student in lrns) // for every lrn in the list
            {
                foreach (int fee in feegroupfees) // for every fee in a feegroup 
                {
                    var feedetails = GetFeesPayments(conn,fee);
                    var fid = feedetails[0]; //feepayment_id
                    var name = feedetails[1]; //name
                    var desc = feedetails[2]; //desc
                    var amount = int.Parse(feedetails[3]); //amount
                    var payment = int.Parse(feedetails[4]); //payment

                    InsertTransaction(conn, amount, payment, name, student.ToString(), feegroupname);
                }
            }
        }

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
                        read.GetValue(read.GetOrdinal("fp_desc")), // desc
                        read.GetValue(read.GetOrdinal("amount")), // amount (balance increasing)
                        //read.GetValue(read.GetOrdinal("fg_name")).ToString();
                });
                }
            }
        }

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
                        read.GetValue(read.GetOrdinal("fp_desc")), // desc
                        read.GetValue(read.GetOrdinal("payment")), // payment (balance decreasing)
                        //read.GetValue(read.GetOrdinal("fg_name")).ToString();
                });
                }
            }
        } //NewGroup

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

    }
}
