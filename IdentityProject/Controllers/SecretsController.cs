using System.Threading.Tasks;
using IdentityProject.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.Controllers
{
    public class SecretsController : Controller
    {
        private readonly IApiService _service;

        public SecretsController(IApiService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Values()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var info = await _service.GetValues(accessToken);

            return View(info);
        }

        public async Task<IActionResult> Secrets()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");
            var info = await _service.GetSecrets(accessToken);

            return View(info);
        }
    }
}
