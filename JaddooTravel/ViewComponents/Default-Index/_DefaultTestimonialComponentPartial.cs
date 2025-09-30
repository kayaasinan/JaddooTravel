using JaddooTravel.Services.DestinationServices;
using JaddooTravel.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _testimonialService.GetAllTestimonialAsync()).OrderByDescending(x => x.TestimonialId).Take(3).ToList();
            return View(values);
        }
    }
}
