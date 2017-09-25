using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace IdentityProject.Services
{
    public class ApiService : IApiService
    {
        public async Task<JArray> GetValues(string accessToken)
        {
            var httpClient = new HttpClient();
            httpClient.SetBearerToken(accessToken);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));


            var response = await httpClient.GetAsync("http://localhost:64548/api/values");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            var content = await response.Content.ReadAsStringAsync();

            return JArray.Parse(content);
        }

        public async Task<JArray> GetSecrets(string accessToken)
        {
            var httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var response = await httpClient.GetAsync("http://localhost:64548/api/secrets");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            var content = await response.Content.ReadAsStringAsync();

            return JArray.Parse(content);
        }
    }
}
