using JaddooTravel.Dtos.TripPlanDtos;
using JaddooTravel.Services.FeatureServices;
using JaddooTravel.Services.TripPlanServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JaddooTravel.Controllers
{
    public class TripPlanController : Controller
    {
        private readonly ITripPlanService _tripPlanService;

        public TripPlanController(ITripPlanService tripPlanService)
        {
            _tripPlanService = tripPlanService;
        }

        public async Task<IActionResult> TripPlanList()
        {
            var values = await _tripPlanService.GetAllTripPlanAsync();
            return View(values);
        }
        public IActionResult CreateTripPlan()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTripPlan(CreateTripPlanDto createTripPlanDto)
        {
            await _tripPlanService.CreateTripPlanAsync(createTripPlanDto);
            return RedirectToAction("TripPlanList");
        }
        public async Task<IActionResult> DeleteTripPlan(string id)
        {
            await _tripPlanService.DeleteTripPlanAsync(id);
            return RedirectToAction("TripPlanList");
        }
        public async Task<ActionResult> UpdateTripPlan(string id)
        {
            var values = await _tripPlanService.GetTripPlanByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<ActionResult> UpdateTripPlan(UpdateTripPlanDto updateTripPlanDto)
        {
            await _tripPlanService.UpdateTripPlanAsync(updateTripPlanDto);
            return RedirectToAction("TripPlanList");
        }

    }
}
