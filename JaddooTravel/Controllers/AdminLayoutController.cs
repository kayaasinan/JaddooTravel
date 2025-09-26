using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
