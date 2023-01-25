using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace UpCount
{
    public partial class Expense
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }
        [BsonRepresentation(BsonType.DateTime)]
        public DateTime Date { get; set; }
        public long Amount { get; set; }
        public string Currency { get; set; }
        public string Subject { get; set; }
    }
}
