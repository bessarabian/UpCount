using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace UpCount
{
    [BsonIgnoreExtraElements]
    public class Expense
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string Subject { get; set; }
    }
}
