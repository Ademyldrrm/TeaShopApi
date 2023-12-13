using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopApi.WebUI.Dtos.ContactDto;
using TeaShopApi.WebUI.Dtos.TestimonialDto;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DashboardCustomerComment:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardCustomerComment(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/Messages/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
