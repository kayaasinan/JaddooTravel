using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Default_Index
{
    public class _DefaultCategoryComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
