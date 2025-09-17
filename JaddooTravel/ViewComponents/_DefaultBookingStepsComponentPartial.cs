using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents
{
    public class _DefaultBookingStepsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
