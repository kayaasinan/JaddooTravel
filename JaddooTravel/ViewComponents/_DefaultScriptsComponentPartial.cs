using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents
{
    public class _DefaultScriptsComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
