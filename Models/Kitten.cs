using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CfSampleAppDotNet.Models
{
    public class Kitten
    {
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
    }
}
