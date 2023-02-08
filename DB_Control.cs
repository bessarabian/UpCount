using System;
using System.Collections.Generic;
using System.IO;
using Dapper;
using System.Linq;
using System.Data.SQLite;

namespace UpCount
{
    public class DB_Control
    {
        public DB_Control() 
        {
            InitDB();
            CreateUserTable();
        }

        public static string GetUpCountFolder()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo currentDirectoryInfo = new(currentDirectory);
            string grandParentPath = currentDirectoryInfo.Parent.Parent.FullName;
            return grandParentPath;
        }

        public static string GetConnectionString()
        {
            string mock = string.Format("{0}\\db\\", GetUpCountFolder());
            string[] files = Directory.GetFiles(mock, "*.sqlite", SearchOption.AllDirectories);
            return string.Format("Data Source={0}", files[0]);
        }

        public void InitDB()
        {
            string finalPath = string.Format("{0}\\db\\database.sqlite", GetUpCountFolder());
            if (!File.Exists(finalPath))
            {
                Console.WriteLine("No database file found, creating...");
                File.Create(finalPath);
                Console.WriteLine("Created database by following path: " + GetConnectionString());

            } else { Console.WriteLine("DB Inited."); }
            
        }

        public void CreateUserTable()
        {
            using SQLiteConnection cnn = new(GetConnectionString());
            cnn.Execute(@"
                   CREATE TABLE IF NOT EXISTS Expenses(
	                ""ID""	INTEGER NOT NULL UNIQUE,
	                ""AMOUNT""	REAL NOT NULL,
                    ""DATE""	TEXT NOT NULL,
                    ""CURRENCY""	TEXT NOT NULL,
                    ""CATEGORY""	TEXT NOT NULL,
                    PRIMARY KEY(""ID"" AUTOINCREMENT))");
        }

        public List<Expense> LoadExpenses()
        {
            using SQLiteConnection cnn = new(@"Data Source=../../db/database.sqlite");
            var output = cnn.Query<Expense>(@"select * from Expenses", new DynamicParameters());
            return output.ToList();
        }

        public void InsertExpense(Expense exp)
        {

            using (var cnn = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand cmd = cnn.CreateCommand();
                cnn.Execute(@"insert into Expenses (AMOUNT, DATE, CURRENCY, CATEGORY) 
                    values(
                        @AMOUNT,
                        @DATE,
                        @CURRENCY,
                        @CATERGORY
                    )", exp);
            };
        }
    }
}
