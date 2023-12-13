using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopApi.WebUI.Dtos.ContactDto;
using TeaShopApi.WebUI.Dtos.DrinkDtos;
using TeaShopApi.WebUI.Dtos.TestimonialDto;

namespace TeaShopApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage1 = await client.GetAsync("https://localhost:7028/api/Statistic/GetDrinkAvargePrice");
             var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            ViewBag.v1= jsonData1;

            var responseMessage2 = await client.GetAsync("https://localhost:7028/api/Statistic/GetLastDrinkName");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            ViewBag.v2 = jsonData2;

            var responseMessage3 = await client.GetAsync("https://localhost:7028/api/Statistic/GetDrinkCount");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            ViewBag.v3 = jsonData3;

            var responseMessage4 = await client.GetAsync("https://localhost:7028/api/Statistic/GetMaxpriceDrink");
            var jsonData4 = await responseMessage4.Content.ReadAsStringAsync();
            ViewBag.v4 = jsonData4;

            var responseMessage5 = await client.GetAsync("https://localhost:7028/api/Statistic/GetLastMessage");
            var jsonData5 = await responseMessage5.Content.ReadAsStringAsync();
            ViewBag.v5 = jsonData5;

            var responseMessage6 = await client.GetAsync("https://localhost:7028/api/Statistic/GetMessageCount");
            var jsonData6 = await responseMessage6.Content.ReadAsStringAsync();
            ViewBag.v6 = jsonData6;

            var responseMessage7 = await client.GetAsync("https://localhost:7028/api/Statistic/GetQuestionCount");
            var jsonData7 = await responseMessage7.Content.ReadAsStringAsync();
            ViewBag.v7 = jsonData7;

            var responseMessage8 = await client.GetAsync("https://localhost:7028/api/Statistic/GetTestimonialCount");
            var jsonData8 = await responseMessage8.Content.ReadAsStringAsync();
            ViewBag.v8 = jsonData8;

            return View();
        }
    }
}
