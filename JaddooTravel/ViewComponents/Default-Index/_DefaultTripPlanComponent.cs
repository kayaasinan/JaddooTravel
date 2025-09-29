using JaddooTravel.Services.TripPlanServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultTripPlanComponent:ViewComponent
    {
        private readonly ITripPlanService _tripPlanService;

        public _DefaultTripPlanComponent(ITripPlanService tripPlanService)
        {
            _tripPlanService = tripPlanService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _tripPlanService.GetAllTripPlanAsync();
            return View(values);
        }
    }
}
