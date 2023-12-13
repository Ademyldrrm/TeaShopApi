using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
