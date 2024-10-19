using Microsoft.AspNetCore.Mvc;
using ProductAPI_Consume.Models;
using System.Diagnostics;
using System.Text.Json;

namespace ProductAPI_Consume.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
           var product = new List<ProductDTO>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44349/api/Products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    product = JsonSerializer.Deserialize<List<ProductDTO>>(apiResponse);
                }
            }
            return View(product);
        }


    }
}
