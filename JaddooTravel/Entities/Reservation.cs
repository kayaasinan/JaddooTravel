using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JaddooTravel.Entities
{
    public class Reservation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string DestinationId { get; set; }

        [BsonIgnoreIfNull]
        public Destination Destination { get; set; }


    }
}
