using Microsoft.AspNetCore.Mvc;
using mvcfull_operation.Data;
using mvcfull_operation.Models;

namespace mvcfull_operation.Controllers
{
    public class LoginController : Controller
    {
        private readonly MvcDbContext _db;

        public LoginController(MvcDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {

            Login _empoyeeLogin = new Login();
            return View(_empoyeeLogin);
        }
        [HttpPost]
        public IActionResult Index(Login _empoyeeLogin)
        {
            MvcDbContext _employeeLogin = new MvcDbContext();
            var status = _employeeLogin.Logins.Where(m => m.Email == _empoyeeLogin.Email && m.Password == _empoyeeLogin.Password).FirstOrDefault();
            if (status == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                return RedirectToAction("SuccessPage", "UserLogin");
            }
            return View(_empoyeeLogin);
        }


      
    }
}
