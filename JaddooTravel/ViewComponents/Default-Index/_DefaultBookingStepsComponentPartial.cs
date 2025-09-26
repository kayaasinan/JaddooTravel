using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultBookingStepsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
