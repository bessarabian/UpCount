using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace Bankier
{
    internal class Bankier
    {
        public static void InsertDataInTable()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.ListDatabases().ToString();

            
        }
    }
}
