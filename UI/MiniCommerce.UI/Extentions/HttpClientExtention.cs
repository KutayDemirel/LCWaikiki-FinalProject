using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Extentions
{
    public static class HttpClientExtensions
    {
        #region GET
        public static async Task<T> ReadContentAs<T>(this HttpClient httpClient, HttpContext httpContext, string url)
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"{url}");

            request.Headers.TryAddWithoutValidation("accept", "*");
            if (httpContext.HasCookie("Authorization"))
            {
                var getCookie = httpContext.GetCookie("Authorization");
                var myCookie = JsonConvert.DeserializeObject<ServiceResponse<LoginModel>>(getCookie);
                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + myCookie.Data.Token);
            }

            var response = await httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");


            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return System.Text.Json.JsonSerializer.Deserialize<T>(dataAsString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
        #endregion


        #region POST
        public static async Task<ServiceResponse<bool>> PostAsJson<T>(this HttpClient httpClient, HttpContext httpContext, string url, T data)
        {


            var request = new HttpRequestMessage(new HttpMethod("POST"), $"{url}");

            request.Headers.TryAddWithoutValidation("accept", "*");
            if (httpContext.HasCookie("Authorization"))
            {
                var getCookie = httpContext.GetCookie("Authorization");
                var myCookie = JsonConvert.DeserializeObject<ServiceResponse<LoginModel>>(getCookie);
                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + myCookie.Data.Token);
            }

            var dataAsString = System.Text.Json.JsonSerializer.Serialize(data);
            request.Content = new StringContent(dataAsString);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            var response = await httpClient.SendAsync(request);


            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");
            else if (response.StatusCode == HttpStatusCode.BadRequest)
                throw new Exception("Hata Oluştu");


            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return System.Text.Json.JsonSerializer.Deserialize<ServiceResponse<bool>>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });




        }
        #endregion

        #region PUT
        public static async Task<ServiceResponse<bool>> PutAsJson<T>(this HttpClient httpClient, HttpContext httpContext, string url, T data)
        {
            var request = new HttpRequestMessage(new HttpMethod("PUT"), $"{url}");

            request.Headers.TryAddWithoutValidation("accept", "*");
            if (httpContext.HasCookie("Authorization"))
            {
                var getCookie = httpContext.GetCookie("Authorization");
                var myCookie = JsonConvert.DeserializeObject<ServiceResponse<LoginModel>>(getCookie);
                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + myCookie.Data.Token);
            }


            var dataAsString = System.Text.Json.JsonSerializer.Serialize(data);

            request.Content = new StringContent(dataAsString);
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");


            var response = await httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");


            var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return System.Text.Json.JsonSerializer.Deserialize<ServiceResponse<bool>>(result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        }
        #endregion

        #region DELETE

        public static async Task<ServiceResponse<bool>> DeleteAs(this HttpClient httpClient, HttpContext httpContext, string url)
        {
            var request = new HttpRequestMessage(new HttpMethod("DELETE"), $"{url}");

            request.Headers.TryAddWithoutValidation("accept", "*");
            if (httpContext.HasCookie("Authorization"))
            {
                var getCookie = httpContext.GetCookie("Authorization");
                var myCookie = JsonConvert.DeserializeObject<ServiceResponse<LoginModel>>(getCookie);
                request.Headers.TryAddWithoutValidation("Authorization", "Bearer " + myCookie.Data.Token);
            }

            var response = await httpClient.SendAsync(request);

            if (!response.IsSuccessStatusCode)
                throw new ApplicationException($"Something went wrong calling the API: {response.ReasonPhrase}");


            var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return System.Text.Json.JsonSerializer.Deserialize<ServiceResponse<bool>>(dataAsString, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        #endregion
    }


}
