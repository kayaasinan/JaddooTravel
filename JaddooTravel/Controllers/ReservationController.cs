using JaddooTravel.Dtos.DestinationDtos;
using JaddooTravel.Dtos.ReservationDtos;
using JaddooTravel.Services.DestinationServices;
using JaddooTravel.Services.ReservationServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace JaddooTravel.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IDestinationService _destinationService;


        public ReservationController(IReservationService reservationService, IDestinationService destinationService)
        {
            _reservationService = reservationService;
            _destinationService = destinationService;
        }

        public async Task<IActionResult> ReservationList()
        {
            var values = await _reservationService.GetAllReservationAsync();
            foreach (var item in values)
            {
                var destination = await _destinationService.GetDestinationByIdAsync(item.DestinationId);
                item.Destination = new ResultDestinationDto
                {
                    DestinationId = destination.DestinationId,
                    CityCountry = destination.CityCountry,
                    DayNight = destination.DayNight,
                    Price = destination.Price
                };
            }
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CreateReservation()
        {
            var destinations = await _destinationService.GetAllDestinationAsync();

            var model = new CreateReservationDto
            {
                DestinationList = destinations
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationDto createReservationDto)
        {
            await _reservationService.CreateReservationAsync(createReservationDto);
            return RedirectToAction("Index", "Default");
        }

        public async Task<IActionResult> DeleteReservation(string id)
        {
            await _reservationService.DeleteReservationAsync(id);
            return RedirectToAction("ReservationList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateReservation(string id)
        {
            var values = await _reservationService.GetReservationByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateReservation(UpdateReservationDto updateReservationDto)
        {
            await _reservationService.UpdateReservationAsync(updateReservationDto);
            return RedirectToAction("ReservationList");
        }

    }
}
