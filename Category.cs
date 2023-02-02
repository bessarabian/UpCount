using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace UpCount
{
    public partial class Categories
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("category_name")]
        public string category_name { get; set; }
    }
}
