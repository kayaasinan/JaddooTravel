using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Admin_Layout
{
    public class _AdminLayoutHeaderComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

