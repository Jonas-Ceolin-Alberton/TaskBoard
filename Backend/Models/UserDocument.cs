
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    [BsonDiscriminator("User")]
    public class UserDocument: MongoDocument
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
