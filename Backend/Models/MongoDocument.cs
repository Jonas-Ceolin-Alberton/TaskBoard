using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Backend.Models
{
    public class MongoDocument
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
