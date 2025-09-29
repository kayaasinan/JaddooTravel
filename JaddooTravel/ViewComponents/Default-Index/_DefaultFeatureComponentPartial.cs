using JaddooTravel.Services.FeatureServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _DefaultFeatureComponentPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.GetAllFeatureAsync();
            return View(values);
        }
    }
}
