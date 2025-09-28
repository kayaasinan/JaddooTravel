using JaddooTravel.Services.DestinationServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultDestinationComponentPartial:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _DefaultDestinationComponentPartial(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _destinationService.GetAllDestinationAsync()).OrderByDescending(x=>x.DestinationId).Take(3).ToList();
            return View(values);
        }
    }
}
