using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Diagnostics.SymbolStore;
using System.Collections.Generic;

namespace UpCount
{
    public class DB_Control
    {
        public MongoClient dbClient;
        
        public DB_Control(string db_connection_string)
        {
             dbClient = new MongoClient(db_connection_string);
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

        public string GetAllExpensesByCurrency(Currency.Currencies curr)
        {
            var db = dbClient.GetDatabase("consumptions");
            var coll = db.GetCollection<Expense>("expenses");

            List<Expense> exp = coll.AsQueryable().ToList();
            var total_sum = 0;

            foreach (var expense in exp)
            {
                if(expense.Currency == curr.ToString()){
                    total_sum += (int)expense.Amount;
                }
                
            }

            return Convert.ToString(total_sum);
        }
    }
}
