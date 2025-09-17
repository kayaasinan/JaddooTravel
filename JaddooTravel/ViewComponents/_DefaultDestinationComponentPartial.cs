using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents
{
    public class _DefaultDestinationComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
