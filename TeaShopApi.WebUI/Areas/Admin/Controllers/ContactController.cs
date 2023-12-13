using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopApi.WebUI.Dtos.ContactDto;

namespace TeaShopApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[area]/[controller]/[action]/{id?}")]
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/Messages");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        public async Task<IActionResult> DeleteMessageAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responMessage = await client.DeleteAsync("https://localhost:7028/api/Messages?id=" + id);
            if (responMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
