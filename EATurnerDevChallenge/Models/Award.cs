using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EATurnerDevChallenge.Models
{
    public class Award
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public bool AwardWon { get; set; }

        public int AwardYear { get; set; }

        public string[] Participants { get; set; }

        [BsonElement("Award")]
        public string AwardName { get; set; }

        public string AwardCompany { get; set; }

    }
}
