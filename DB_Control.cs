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

        public void DatabaseInsertExpense(double amount, string subject) 
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            var database = _dbClient.GetDatabase("consumptions");
            var collection = database.GetCollection<BsonDocument>("expenses");
            var document = new BsonDocument
            {
                {"date", date},
                {"amount", amount},
                {"currency", "mock"},
                {"subject", subject}
            };

            collection.InsertOneAsync(document);

            var collections = database.GetCollection<BsonDocument>("expenses");
            var documents = collections.Find(new BsonDocument()).ToList();

            foreach (BsonDocument item in documents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
