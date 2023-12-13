using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaultBannerComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
