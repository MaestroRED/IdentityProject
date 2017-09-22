using System.Collections.Generic;
using IdentityServer4.Models;

namespace IdentityProject.IdentityServer.Config
{
    public static class Apis
    {
        public static IEnumerable<ApiResource> Get()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }
    }
}
