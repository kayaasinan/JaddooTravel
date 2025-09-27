using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Admin_Layout
{
    public class _AdminLayoutFooterScript:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
