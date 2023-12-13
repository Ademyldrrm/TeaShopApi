using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopApi.WebUI.Dtos.DrinkDtos;
using TeaShopApi.WebUI.Dtos.TestimonialDto;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DashboardProjectPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardProjectPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/Testimonials/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultTestimonialDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
