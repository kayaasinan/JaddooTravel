using JaddooTravel.Services.OpenAIServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.Controllers
{
    public class AIController : Controller
    {
        private readonly IOpenAIService _openAIService;

        public AIController(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        [HttpPost]
        public async Task<IActionResult> GetPlaces(string city, string country)
        {
            if (string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(country))
                return Json(new { success = false, data = "Lütfen hem şehir hem ülke giriniz." });

            var result = await _openAIService.GetPlacesAsync(city, country);

            return Json(new { success = true, data = result });
        }
    }
}
