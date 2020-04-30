using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EATurnerDevChallenge.Models
{
    public class OtherName
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string TitleNameLanguage { get; set; }

        public string TitleNameType { get; set; }

        public string TitleNameSortable { get; set; }

        public string TitleName { get; set; }
    }
}
