
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    [BsonDiscriminator("User")]
    public class UserEntity: MongoEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
