using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View();
        }
    }
}
