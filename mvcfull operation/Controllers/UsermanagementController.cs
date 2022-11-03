using Microsoft.AspNetCore.Mvc;

namespace mvcfull_operation.Controllers
{
    public class UsermanagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
