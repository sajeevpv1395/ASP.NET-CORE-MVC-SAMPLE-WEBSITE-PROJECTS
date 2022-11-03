using Microsoft.AspNetCore.Mvc;

namespace mvcfull_operation.Controllers
{
    public class HomeLoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
