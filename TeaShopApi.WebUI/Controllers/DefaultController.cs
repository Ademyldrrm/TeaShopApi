using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using TeaShopApi.WebUI.Dtos.MessageDto;

namespace TeaShopApi.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult _MessagePartial()
        {
            return PartialView();
        }
        [HttpPost]
        public async Task<IActionResult> _MessagePartial(CreateMessageDto createMessageDto)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createMessageDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7028/api/Messages", content);
            return RedirectToAction("Index", "Default");

        }

    }
}
