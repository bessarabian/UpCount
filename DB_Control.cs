using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;
using System.IO;

namespace UpCount
{
    public class DB_Control
    {
        public MongoClient dbClient;

        public DB_Control(string db_connection_string)
        {
        }

        public void DatabaseInsertExpense(string date, double amount, string currency, string subject)
        {
            var db = dbClient.GetDatabase("consumptions");
            var collection = db.GetCollection<BsonDocument>("expenses");
            var document = new BsonDocument
            {
                {"date", date},
                {"amount", amount},
                {"currency", currency},
                {"subject", subject}
            };
            collection.InsertOneAsync(document);
        }

        public string GetAllExpensesByCurrency(Attribute.Currencies curr)
        {
            var db = dbClient.GetDatabase("consumptions");
            var coll = db.GetCollection<Expense>("expenses");

            List<Expense> exp = coll.AsQueryable().ToList();
            var total_sum = 0;
            foreach (var expense in exp)
            {
                if (expense.Currency == curr.ToString()) {
                    total_sum += (int)expense.Amount;
                }

            }
            return Convert.ToString(total_sum);
        }

        public void DatabaseInsertCategory(string category_name)
        {
            var db = dbClient.GetDatabase("consumptions");
            var coll = db.GetCollection<BsonDocument>("categories");

            var document = new BsonDocument
            {
                {"category_name", category_name}
            };

            coll.InsertOneAsync(document);
        }

        public List<string> GetAllCategories()
        {
            var db = dbClient.GetDatabase("consumptions");
            var coll = db.GetCollection<Categories>("categories");
            var filter = new BsonDocument();

            List<Categories> categories = coll.AsQueryable().ToList();
            List<string> names = new List<string>();

            foreach (var i in categories)
            {
                names.Add(i.category_name.ToString());
            }


            return names;
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
