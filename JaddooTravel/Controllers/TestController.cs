using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
