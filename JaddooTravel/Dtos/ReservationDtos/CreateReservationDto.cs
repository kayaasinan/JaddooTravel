using JaddooTravel.Dtos.DestinationDtos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JaddooTravel.Dtos.ReservationDtos
{
    public class CreateReservationDto
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string DestinationId { get; set; }
        public List<ResultDestinationDto> DestinationList { get; set; }
    }
}
