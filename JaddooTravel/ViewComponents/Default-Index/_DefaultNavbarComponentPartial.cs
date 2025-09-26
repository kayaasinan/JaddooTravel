using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
