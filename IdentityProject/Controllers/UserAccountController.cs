using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityProject.Controllers
{
    public class UserAccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
