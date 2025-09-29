using JaddooTravel.Dtos.DestinationDtos;
using JaddooTravel.Dtos.ReservationDtos;
using JaddooTravel.Services.DestinationServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultBookingStepsComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _DefaultBookingStepsComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var destinations = await _destinationService.GetAllDestinationAsync();

            var model = new CreateReservationDto
            {
                DestinationList = destinations.ToList()
            };

            return View(model);
        }
    }
}
