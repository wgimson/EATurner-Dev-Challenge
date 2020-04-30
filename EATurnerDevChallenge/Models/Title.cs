using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EATurnerDevChallenge.Models
{
    [BsonIgnoreExtraElements]
    public class Title
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public Award[] Awards { get; set; }

        public string[] Genres { get; set; }

        public OtherName[] OtherNames { get; set; }

        public Participant[] Participants { get; set; }

        public int ReleaseYear { get; set; }

        public StoryLine[] Storylines {get;set;}

        public int TitleId { get; set; }

        public string TitleName { get; set; }

        public string TitleNameSortable { get; set; }
    }
}

