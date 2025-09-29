using JaddooTravel.Dtos.DestinationDtos;
using JaddooTravel.Dtos.TripPlanDtos;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JaddooTravel.Dtos.ReservationDtos
{
    public class ResultReservationDto
    {
        public string ReservationId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string DestinationId { get; set; }
        public ResultDestinationDto Destination { get; set; }
        public List<ResultTripPlanDto> TripPlans { get; set; }
    }
}
