using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Admin_Layout
{
    public class _AdminLayoutSidebarComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
