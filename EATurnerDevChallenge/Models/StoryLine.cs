using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace EATurnerDevChallenge.Models
{
    public class StoryLine
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        public string Type { get; set; }
    }
}
