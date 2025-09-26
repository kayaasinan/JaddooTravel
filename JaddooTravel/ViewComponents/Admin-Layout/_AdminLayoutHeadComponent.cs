using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Admin_Layout
{
    public class _AdminLayoutHeadComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
