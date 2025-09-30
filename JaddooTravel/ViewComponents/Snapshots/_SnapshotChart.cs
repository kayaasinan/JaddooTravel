using JaddooTravel.Services.SnapshotServices;
using Microsoft.AspNetCore.Mvc;

namespace JaddooTravel.ViewComponents.Snapshots
{
    public class _SnapshotChart : ViewComponent
    {

        private readonly ISnapshotService _service;
        public _SnapshotChart(ISnapshotService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _service.GetGraficDataAsync();
            return View(values);
        }
    }
}
