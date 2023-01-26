using MongoDB.Driver;
using MongoDB.Bson;
using System;

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

            Console.WriteLine($"currency: {currency}");

            collection.InsertOneAsync(document);
        }
    }
}
