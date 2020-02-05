using Blaze.Services.Interface;
using BlazeShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Blaze.Services.Class
{
    public class LoginDataServices : ILoginDataServices
    {
        private readonly HttpClient _httpClient;

        public LoginDataServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> ValidateLogin(UserModel userModel)
        {
            var loginDetails =
                new StringContent(JsonSerializer.Serialize(userModel), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Auth/login", loginDetails);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStreamAsync();
                return result.ToString();
            }

            return null;
        }
    }
}
