using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityProject.API.Controllers
{
    [Route("/api/[controller]")]
    [Authorize]
    public class SecretsController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"FirstSecret", "and", "Don't tell anyone"};
        }
    }
}
