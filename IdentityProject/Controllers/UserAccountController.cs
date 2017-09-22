using System.Threading.Tasks;
using IdentityModel.Client;
using IdentityProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityProject.Controllers
{
    public class UserAccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnurl = null)
        {
            ViewData["ReturnURL"] = returnurl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnurl = null)
        {
            ViewData["ReturnURL"] = returnurl;

            if (ModelState.IsValid)
            {
                var disco = await DiscoveryClient.GetAsync("http://localhost:5000");
                var tokenClient = new TokenClient(disco.TokenEndpoint, "resourceOwner", "secret");
                var tokenResponse = await tokenClient.RequestResourceOwnerPasswordAsync(loginViewModel.Username, loginViewModel.Password, "api1");

                if (tokenResponse.IsError)
                {
                    ModelState.AddModelError(string.Empty, tokenResponse.ErrorDescription);
                }
            }

            return View(loginViewModel);
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
