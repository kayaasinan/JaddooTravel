using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JaddooTravel.Dtos.ReservationDtos
{
    public class ResultReservationDto
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string DestinationId { get; set; }
    }
}
