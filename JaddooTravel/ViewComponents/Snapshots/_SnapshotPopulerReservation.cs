using JaddooTravel.Services.ReservationServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Snapshots
{
    public class _SnapshotPopulerReservation:ViewComponent
    {
        private readonly IReservationService _reservationService;

        public _SnapshotPopulerReservation(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _reservationService.GetAllReservationAsync()).OrderByDescending(x => x.DestinationId).Take(4).ToList();
            return View(values);
        }
    }
}
