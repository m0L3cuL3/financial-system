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
            string GeneralLedger = "CREATE TABLE Student(sid INTEGER PRIMARY KEY AUTOINCREMENT, FirstName VARCHAR NOT NULL, MiddleName VARCHAR NOT NULL, Surname VARCHAR NOT NULL, Section VARCHAR NOT NULL, YearLevel INT NOT NULL);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = GeneralLedger;
            sqlite_cmd.ExecuteNonQuery();

            // STUDENT_TRANSACTION //
            string Accounts = "CREATE TABLE Student_Transaction(tid INTEGER PRIMARY KEY AUTOINCREMENT, Term VARCHAR NOT NULL, Type VARCHAR NOT NULL, Amount INT NOT NULL, sid INT NOT NULL, FOREIGN KEY (sid) REFERENCES Student(sid));";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Accounts;
            sqlite_cmd.ExecuteNonQuery();

            // TRANSACTION_LEDGER //
            string JournalEntries = "CREATE TABLE Transaction_Ledger(lid INTEGER PRIMARY KEY AUTOINCREMENT, Fullname VARCHAR NOT NULL, sid INT NOT NULL, FOREIGN KEY(sid) REFERENCES Student(sid));";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = JournalEntries;
            sqlite_cmd.ExecuteNonQuery();
        }

        public void InsertStudentData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            string insertData = "INSERT INTO Student(FirstName, MiddleName, Surname, Section, YearLevel) VALUES (@fname, @midname, @surname, @section, @yearLevel);";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = insertData;

            sqlite_cmd.Parameters.AddWithValue("@fname", "John");
            sqlite_cmd.Parameters.AddWithValue("@midname", "Richard");
            sqlite_cmd.Parameters.AddWithValue("@surname", "Doe");
            sqlite_cmd.Parameters.AddWithValue("@section", "Section X");
            sqlite_cmd.Parameters.AddWithValue("@yearLevel", 1);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void ReadStudentData(SQLiteConnection conn, DataGridView dgv)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = new SQLiteCommand("SELECT * FROM Student", conn);

            using(SQLiteDataReader read = sqlite_cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dgv.Rows.Add(new object[] {
                        read.GetValue(read.GetOrdinal("sid")),
                        read.GetValue(read.GetOrdinal("FirstName")),  // Or column name like this
                        read.GetValue(read.GetOrdinal("MiddleName")),
                        read.GetValue(read.GetOrdinal("Surname")),
                        read.GetValue(read.GetOrdinal("Section")),
                        read.GetValue(read.GetOrdinal("YearLevel"))
                    });
                }
            }
        }
    }
}
