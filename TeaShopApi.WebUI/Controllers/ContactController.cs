using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
