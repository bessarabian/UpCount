using MongoDB.Driver;
using System;

namespace UpCount
{
    internal class DB_Control
    {
        public DB_Control() 
        {
            MongoClient db_client = new MongoClient("mongodb://localhost:27017");
            
        } 
        
    }
}
