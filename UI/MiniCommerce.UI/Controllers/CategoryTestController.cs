using Microsoft.AspNetCore.Mvc;
using MiniCommerce.Application.Repositories.ProductRepo;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class CategoryTestController : Controller
    {

        #region Test

        public async Task<IActionResult> Index()
        {
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44381/api/v1/Category");
            var jsonString = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<Class1>>(jsonString);
            return View(values);
        }

        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory(Class1 p)
        {
            var httpClient = new HttpClient();
            var jsonCategory = JsonConvert.SerializeObject(p);
            StringContent content = new StringContent(jsonCategory, Encoding.UTF8, "application/json");
            var responseMessage = await httpClient.PostAsync("https://localhost:44381/api/v1/Category", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(p);
        }

        #endregion
    }

    #region Test Model

    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    #endregion
}
