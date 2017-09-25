using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace IdentityProject.Services
{
    public interface IApiService
    {
        Task<JArray> GetValues(string accessToken);
        Task<JArray> GetSecrets(string accessToken);
    }
}
