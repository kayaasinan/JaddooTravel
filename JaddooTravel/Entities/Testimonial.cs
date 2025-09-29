using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JaddooTravel.Entities
{
    public class Testimonial
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TestimonialId { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string ProfileImageUrl { get; set; }
        public string Notes { get; set; }
    }
}
