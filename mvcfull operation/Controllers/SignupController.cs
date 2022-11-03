using Microsoft.AspNetCore.Mvc;
using mvcfull_operation.Data;
using mvcfull_operation.Models;

namespace mvcfull_operation.Controllers
{
    public class SignupController : Controller
    {
        private readonly MvcDbContext _db;

        public SignupController(MvcDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public (int, string) SaveSignUp(Signup obj)
        {
            (int, string) result = (0, String.Empty);
            Signup signup = new Signup();
            signup.Id = obj.Id;
            signup.FirstName=obj.FirstName;
            signup.LastName=obj.LastName;
            signup.Email=obj.Email;
            signup.PhoneNumber=obj.PhoneNumber;
            signup.Qualification=obj.Qualification;
          
            if (obj.FirstName == null)
            {
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
                result = (2, "please fill mandatory  fields");
            }
            if (ModelState.IsValid)
            {
                _db.Signups.Add(signup);
                _db.SaveChanges();
                result = (1, "data uploaded successfully");


            }

            return result;
        }

    }
}

