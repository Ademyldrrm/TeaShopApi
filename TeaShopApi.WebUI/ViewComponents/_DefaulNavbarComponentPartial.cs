using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaulNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
