using Microsoft.AspNetCore.Mvc;
using FormValidation.Models;
namespace FormValidation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SingUp()
        {
            return View();
        }


        [HttpPost]

        public IActionResult SingUp(usermodel model)
        {
            //

            if (ModelState.IsValid)
            {

                 return RedirectToAction();

            }
            return View();
        }
        public IActionResult Message()
        {

            return View();
        }
    }
}
