using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string StudentTable = "CREATE TABLE Student(student_id INTEGER PRIMARY KEY AUTOINCREMENT, first_name VARCHAR NOT NULL, middle_name VARCHAR NOT NULL, surname VARCHAR NOT NULL, section VARCHAR NOT NULL, level INT NOT NULL);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = StudentTable;
            sqlite_cmd.ExecuteNonQuery();

            // STUDENT_TRANSACTION //
            string TransactionTable = "CREATE TABLE Student_Transaction(transaction_id INTEGER PRIMARY KEY AUTOINCREMENT, amount VARCHAR NOT NULL, date DATE NOT NULL, type VARCHAR NOT NULL, student_id INT NOT NULL, FOREIGN KEY (student_id) REFERENCES Student(student_id));";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = TransactionTable;
            sqlite_cmd.ExecuteNonQuery();

            // TRANSACTION_LEDGER //
            string StudentLedgerTable = "CREATE TABLE Student_Ledger(ledger_id INTEGER PRIMARY KEY AUTOINCREMENT, transaction_id INT NOT NULL, student_id INT NOT NULL, FOREIGN KEY(transaction_id) REFERENCES Student_Transaction(transaction_id), FOREIGN KEY(student_id) REFERENCES Student(student_id));";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = StudentLedgerTable;
            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertStudentData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Student(first_name, middle_name, surname, section, level) VALUES (@fname, @midname, @surname, @section, @level);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fname", "Jane");
            sqlite_cmd.Parameters.AddWithValue("@midname", "Rachele");
            sqlite_cmd.Parameters.AddWithValue("@surname", "Doe");
            sqlite_cmd.Parameters.AddWithValue("@section", "Section X");
            sqlite_cmd.Parameters.AddWithValue("@level", 1);

            sqlite_cmd.ExecuteNonQuery();
        }


        public string GetStudentName(SQLiteConnection conn, int id)
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
        }

    }
}
