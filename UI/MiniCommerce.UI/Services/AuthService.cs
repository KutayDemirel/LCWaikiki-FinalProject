using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuthService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SignIn(SignInModel user)
        {
            string url = $"/api/v1/Auth/SignIn?email={user.Email}&password={user.Password}";

            var request = new HttpRequestMessage(new HttpMethod("POST"), $"{url}");

            request.Headers.TryAddWithoutValidation("accept", "*/*");
            if (_httpContextAccessor.HttpContext.HasCookie("Authorization"))
            {
                var myCookie = _httpContextAccessor.HttpContext.GetCookie("Authorization");
                request.Headers.TryAddWithoutValidation("Authorization", myCookie);
            }

            var dataAsString = System.Text.Json.JsonSerializer.Serialize(user);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(url, content);

            //if (!response.IsSuccessStatusCode)
            //    throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");
            //else if (response.StatusCode == HttpStatusCode.BadRequest)
            //    throw new Exception("Hata Oluştu");


            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return result;
        } 
        
        
        public async Task<string> SignUp(SignUpModel user)
        {
            string url = $"/api/v1/Auth/SignUp?email={user.Email}&password={user.Password}";

            var request = new HttpRequestMessage(new HttpMethod("POST"), $"{url}");

            

            var dataAsString = System.Text.Json.JsonSerializer.Serialize(user);
            var content = new StringContent(dataAsString);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await _client.PostAsync(url, content);

            //if (!response.IsSuccessStatusCode)
            //    throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");
            //else if (response.StatusCode == HttpStatusCode.BadRequest)
            //    throw new Exception("Hata Oluştu");


            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return result;
        }
    }

}
