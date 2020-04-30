using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EATurnerDevChallenge.Models
{
    [BsonIgnoreExtraElements]
    public class Participant
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public bool IsKey { get; set; }

        public string RoleType { get; set; }

        public bool IsOnScreen { get; set; }

        public string ParticipantType { get; set; }

        public string Name { get; set; }

        public int ParticipantId { get; set; }
    }
}
