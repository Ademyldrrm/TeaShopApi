using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
