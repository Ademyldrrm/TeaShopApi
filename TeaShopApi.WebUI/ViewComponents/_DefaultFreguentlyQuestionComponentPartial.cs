using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TeaShopApi.WebUI.Dtos.DrinkDtos;
using TeaShopApi.WebUI.Dtos.QuestionDtos;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaultFreguentlyQuestionComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultFreguentlyQuestionComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7028/api/Questions/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultQuestionDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
