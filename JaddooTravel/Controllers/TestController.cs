using JaddooTravel.Dtos.CategoryDtos;
using JaddooTravel.Dtos.DestinationDtos;
using JaddooTravel.Helpers;
using JaddooTravel.Models.GridView;
using JaddooTravel.Services.DestinationServices;
using JaddooTravel.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.Controllers
{
    public class TestController : Controller
    {
        private readonly IDestinationService _destinationService;

        public TestController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task< IActionResult> DemoGrid()
        {
            var vm=new DemoGridViewModel();
            var values = await _destinationService.GetAllDestinationAsync();

            var gridOptions = GridHelpers.GetGridOptions(new ResultDestinationDto(),values, new string[] { "btn_Detail_Task", "btn_Delete_Task" });
          
            return View(vm);
        }
    }
}
