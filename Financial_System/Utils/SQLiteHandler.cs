using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


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

            // GENERAL LEDGER //
            string GeneralLedger = "CREATE TABLE GeneralLedger(Date VARCHAR(20), Account VARCHAR(20), RefType VARCHAR(20), Debit INT, Credit INT, Balance INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = GeneralLedger;
            sqlite_cmd.ExecuteNonQuery();

            // ACCOUNTS //
            string Accounts = "CREATE TABLE Accounts(AccountName VARCHAR(20), RootType VARCHAR(20), AccountType VARCHAR(20))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Accounts;
            sqlite_cmd.ExecuteNonQuery();

            // JOURNAL ENTRIES //
            string JournalEntries = "CREATE TABLE JournalEntries()"; // -> create table for journal entries.
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = JournalEntries;
            sqlite_cmd.ExecuteNonQuery();
        }
    }
}
