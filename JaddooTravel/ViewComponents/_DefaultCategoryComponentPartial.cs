using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents
{
    public class _DefaultCategoryComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
