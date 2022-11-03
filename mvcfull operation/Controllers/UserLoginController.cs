using Microsoft.AspNetCore.Mvc;
using mvcfull_operation.Data;
using mvcfull_operation.Models;
namespace mvcfull_operation.Controllers
{
    public class UserLoginController : Controller
    {
        private readonly MvcDbContext _db;

        public UserLoginController(MvcDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            EmpoyeeModel _empoyeeModel = new EmpoyeeModel();
            return View(_empoyeeModel);
        }
        [HttpPost]
        public IActionResult Index(EmpoyeeModel _empoyeeModel)
        {
            MvcDbContext _employeeContext = new MvcDbContext();
            var status = _employeeContext.UserLogins.Where(m => m.Email == _empoyeeModel.Email && m.Pasword == _empoyeeModel.Pasword).FirstOrDefault();
            if (status == null)
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                return RedirectToAction("SuccessPage", "Home");
            }
            return View(_empoyeeModel);
        }
        public IActionResult SuccessPage()
        {
            return View();
        }
    }
}
