using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.Controllers
{
    public class SnapshotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
