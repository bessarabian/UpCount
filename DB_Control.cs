using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Data;
using Dapper;
using System.Linq;

namespace UpCount
{
    public class DB_Control
    {
        public static string GetConnectionString()
        {
            string[] files = Directory.GetFiles("../../", "*.sqlite", SearchOption.AllDirectories);
            Console.WriteLine(files[0]);
            return files[0].ToString();
        }

        public void InitDB()
        {
            if (!File.Exists(@"../../db/database.sqlite"))
            {
                Console.WriteLine("No database file found, creating...");
                File.Create(@"../../db/database.sqlite");
                Console.WriteLine("Created database by following path: " + GetConnectionString());
            }
            Console.WriteLine("DB Inited.");
        }

        public void CreateTable(SqliteConnection conn)
        {
            SqliteCommand sqliteCmd = conn.CreateCommand();
            sqliteCmd.CommandText = @"
                   CREATE TABLE ""Expenses"" (
	                ""ID""	INTEGER NOT NULL UNIQUE,
	                ""AMOUNT""	REAL NOT NULL,
                    ""DATE""	TEXT NOT NULL,
                    ""CURRENCY""	TEXT NOT NULL,
                    ""CATEGORY""	TEXT NOT NULL,
                    PRIMARY KEY(""ID"" AUTOINCREMENT))";
            sqliteCmd.ExecuteNonQuery();
        }

        public List<Expense> LoadExpenses()
        {
            using IDbConnection cnn = new SqliteConnection(@"Data Source=../../db/database.sqlite");
            var output = cnn.Query<Expense>("select * from Expenses");
            return output.ToList();
        }

        public void AddExpense(string date, double amount, string currency, string subject)
        {

            using (var connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.OpenAsync();
                using (var cmd = new SqliteCommand())
                {

                }
            };
        }
    }
}
