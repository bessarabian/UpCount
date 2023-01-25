using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace UpCount
{
    public class DB_Control
    {
        private MongoClient _dbClient;
        
        public DB_Control(string db_connection_string)
        {
            _dbClient = new MongoClient(db_connection_string);
        }

        public IMongoCollection<BsonDocument> GetCollect(string dbname, string collname)
        {
            var database = _dbClient.GetDatabase(dbname);
            var collection = database.GetCollection<BsonDocument>(collname);

            return collection;
        }

        public void aaa()
        {
            var collection = GetCollect("consumptions", "expenses");

            var result = collection.Find(new BsonDocument()).ToList();


        }

        public void DatabaseInsertExpense(double amount, string subject, Currency.Currencies currency) 
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            var collection = GetCollect("consumptions", "expenses");
            var document = new BsonDocument
            {
                {"date", date},
                {"amount", amount},
                {"currency", currency.ToString()},
                {"subject", subject}
            };

            collection.InsertOneAsync(document);
        }
    }
}
