using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }
        [HttpGet("GetDrinkAvargePrice")]
        public IActionResult GetDrinkAvargePrice()
        {
            decimal averagePrice = _statisticService.TDrinkAvargePrice();
            return Ok(averagePrice);
        }

        [HttpGet("GetLastDrinkName")]
        public IActionResult GetLastDrinkName()
        {
            string lastDrinkName = _statisticService.TLastDrinkName();
            return Ok(lastDrinkName);
        }
        [HttpGet("GetDrinkCount")]
        public IActionResult GetDrinkCount()
        {
            int lastDrinkName = _statisticService.TDrinkCount();
            return Ok(lastDrinkName);
        }
        [HttpGet("GetMaxpriceDrink")]
        public IActionResult GetMaxpriceDrink()
        {
            string lastDrinkName = _statisticService.TMaxPriceDrink();
            return Ok(lastDrinkName);
        }
        [HttpGet("GetLastMessage")]
        public IActionResult GetLastMessage()
        {
            string lastMessage=_statisticService.TLastMessage();
            return Ok(lastMessage);
        }
        [HttpGet("GetMessageCount")]
        public IActionResult GetMessageCount()
        {
            int messageCount = _statisticService.TMessageCount();
            return Ok(messageCount);
        }
        [HttpGet("GetQuestionCount")]
        public IActionResult GetQuestionCount()
        {
            int lastMessage = _statisticService.TQuestionCount();
            return Ok(lastMessage);
        }
        [HttpGet("GetTestimonialCount")]
        public IActionResult GetTestimonialCount()
        {
            int testimonialCount = _statisticService.TTestimonialCount();
            return Ok(testimonialCount);
        }

    }
}
