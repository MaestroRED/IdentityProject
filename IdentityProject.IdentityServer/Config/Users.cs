using System.Collections.Generic;
using IdentityModel.Client;
using IdentityServer4.Test;

namespace IdentityProject.IdentityServer.Config
{
    public static class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>()
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "1",
                    Password = "1"
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "2",
                    Password = "2"
                }
            };
        }
    }
}
