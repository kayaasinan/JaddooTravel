using JaddooTravel.Services.DestinationServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Snapshots
{
    public class _SnapshotPopularDestination:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _SnapshotPopularDestination(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _destinationService.GetAllDestinationAsync()).OrderByDescending(x => x.DestinationId).Take(4).ToList();
            return View(values);
        }
    }
}
