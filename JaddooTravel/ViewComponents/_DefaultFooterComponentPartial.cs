using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents
{
    public class _DefaultFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
