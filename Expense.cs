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
        [BsonElement("date")]
        public string Date { get; set; }
        [BsonElement("amount")]
        public double Amount { get; set; }
        [BsonElement("currency")]
        public string Currency { get; set; }
        [BsonElement("subject")]
        public string Subject { get; set; }

        public Expense(string date, double amount, string currency, string subject)
        {
            Date = date;
            Amount = amount;
            Currency = currency;
            Subject = subject;
        }
    }
}
