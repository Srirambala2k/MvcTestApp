using Microsoft.AspNetCore.Mvc;
using MvcTestApp.Data;

namespace MvcTestApp.Controllers
{
    public class RequestController : Controller
    {
        RequestDataService requestDataService;
        public RequestController()
        {
            requestDataService = new RequestDataService();
        }
        public IActionResult Index()
        {
            var requests =requestDataService.GetRequest();
            return View(requests);
        }
    }
}
