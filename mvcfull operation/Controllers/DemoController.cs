using Microsoft.AspNetCore.Mvc;

namespace mvcfull_operation.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
