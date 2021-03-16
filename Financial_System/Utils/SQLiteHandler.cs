using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Financial_System.Utils
{
    interface ISQLite
    {
        SQLiteConnection CreateConnection();
        void CreateTable(SQLiteConnection conn);
    }

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

        public void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            // STUDENT //
            string StudentTable = "CREATE TABLE IF NOT EXISTS Student_tbl(student_id INTEGER PRIMARY KEY AUTOINCREMENT, first_name VARCHAR NOT NULL, middle_name VARCHAR NOT NULL, surname VARCHAR NOT NULL, section VARCHAR NOT NULL, level INT NOT NULL);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = StudentTable;
            sqlite_cmd.ExecuteNonQuery();

            // TRANSACTION // renamed by alexislyndon
            string TransactionTable = "CREATE TABLE IF NOT EXISTS Transaction_tbl(transaction_id INTEGER PRIMARY KEY AUTOINCREMENT, amount INT NOT NULL, type VARCHAR NOT NULL, student_id INT NOT NULL, receipt_number VARCHAR NOT NULL, term INT NOT NULL, date_recorded DATE NOT NULL DEFAULT CURRENT_TIMESTAMP, user INT NULL, FOREIGN KEY(student_id) REFERENCES Student_tbl(student_id), FOREIGN KEY(term) REFERENCES Term_tbl(term_id), FOREIGN KEY(user) REFERENCES User_tbl(user_id));";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = TransactionTable;
            sqlite_cmd.ExecuteNonQuery();

            // LEDGER // renamed by alexislyndon
            string StudentLedgerTable = "CREATE TABLE IF NOT EXISTS Ledger_tbl(ledger_id INTEGER PRIMARY KEY AUTOINCREMENT, transaction_id INT NOT NULL, term INT NOT NULL, isClosed BOOLEAN NOT NULL , FOREIGN KEY(transaction_id) REFERENCES Student_Transaction(transaction_id), FOREIGN KEY(term) REFERENCES Term(term_id));";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = StudentLedgerTable;
            sqlite_cmd.ExecuteNonQuery();

            // TERM //
            string TermTable = "CREATE TABLE IF NOT EXISTS Term_tbl(term_id INTEGER PRIMARY KEY, startdate DATE NOT NULL, enddate DATE NOT NULL, current BOOLEAN NOT NULL);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = TermTable;
            sqlite_cmd.ExecuteNonQuery();

            // User //
            string UserTable = "CREATE TABLE IF NOT EXISTS User_tbl(user_id INTEGER PRIMARY KEY, createdate DATE NOT NULL DEFAULT CURRENT_TIMESTAMP, enddate DATE NOT NULL);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = UserTable;
            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertStudentData(SQLiteConnection conn)
        {//For testing only. We don't insert students, enrolment team does. Maybe we could ask JB for an API
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Student_tbl(first_name, middle_name, surname, section, level) VALUES (@fname, @midname, @surname, @section, @level);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fname", "Jorge");
            sqlite_cmd.Parameters.AddWithValue("@midname", "David");
            sqlite_cmd.Parameters.AddWithValue("@surname", "Nuñez");
            sqlite_cmd.Parameters.AddWithValue("@section", "St. Thomas Aquinas");
            sqlite_cmd.Parameters.AddWithValue("@level", 7);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertTransaction (SQLiteConnection conn, int amount, string type, string sid, string receipt)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Transaction_tbl(amount, type, student_id, receipt_number, term, date_recorded) VALUES (@amount, @type, @sid, @receipt, @term, @date_recorded);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            int term = 2002;

            sqlite_cmd.Parameters.AddWithValue("@amount", amount);
            sqlite_cmd.Parameters.AddWithValue("@type", type);
            sqlite_cmd.Parameters.AddWithValue("@sid", sid);
            sqlite_cmd.Parameters.AddWithValue("@receipt", receipt);
            sqlite_cmd.Parameters.AddWithValue("@term", term);
            sqlite_cmd.Parameters.AddWithValue("@date_recorded", DateTime.Now); 

            sqlite_cmd.ExecuteNonQuery();
        }

        public void TermInit(SQLiteConnection conn)
        {//make 1 term 2002
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Term_tbl(term_id, startdate, enddate, current) VALUES (@term, @start, @end, @current);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            int term = 2002;
            DateTime start = new DateTime(2021, 1, 1);
            DateTime end = new DateTime(2021, 5, 31);

            sqlite_cmd.Parameters.AddWithValue("@term", term);
            sqlite_cmd.Parameters.AddWithValue("@start", start);
            sqlite_cmd.Parameters.AddWithValue("@end", end);
            sqlite_cmd.Parameters.AddWithValue("@current", true);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void InitializeStudentLedger(SQLiteConnection conn, int term, int sid, int tid, Boolean isClosed)
        { //first transaction of the of the term
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Ledger_tbl( term, student_id, transaction_id, isClosed) VALUES (@term, @sid, @tid, @isClosed);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@term", term);
            sqlite_cmd.Parameters.AddWithValue("@sid", sid);
            sqlite_cmd.Parameters.AddWithValue("@tid", tid);
            sqlite_cmd.Parameters.AddWithValue("@isClosed", isClosed);
            //sqlite_cmd.Parameters.AddWithValue("@receipt", receipt);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertTransactiontoLedger(SQLiteConnection conn,int lid , int term, int sid, int tid, bool isClosed)
        {//subsequent transactions of of a student
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Ledger_tbl(ledger_id, term, student_id, transaction_id, isClosed) VALUES (@lid,@term, @sid, @tid, @isClosed);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@lid", lid);
            sqlite_cmd.Parameters.AddWithValue("@term", term);
            sqlite_cmd.Parameters.AddWithValue("@sid", sid);
            sqlite_cmd.Parameters.AddWithValue("@tid", tid);
            sqlite_cmd.Parameters.AddWithValue("@isClosed", isClosed);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void GetStudentData(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = new SQLiteCommand("Select * From Student_tbl ", conn);
            using (SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(0),  // id
                        read.GetString(1) + " " + read.GetString(2) + " " + read.GetString(3), // fullname
                        read.GetString(4), // section
                        read.GetInt32(5).ToString() // level
                    });
                }
            }
        }

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
                        read.GetValue(1), // amount
                        read.GetValue(2), // type
                        read.GetValue(4) // receipt
                        //read.GetString(4), // receipt
                    });
                }
            }
        }

        /*public string GetStudentName(SQLiteConnection conn, int id)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT first_name, middle_name, surname FROM Student WHERE student_id = @id", conn);

            sqlite_cmd.Parameters.AddWithValue("@id", id);

            SQLiteDataReader read = sqlite_cmd.ExecuteReader();

            if (read.Read())
            {
                return read.GetString(1) + " " + read.GetString(2) + " " + read.GetString(3); // student fullname.
            }
            else
            {
                return "Student Does Not Exist!";
            }
        }*/

    }
}
