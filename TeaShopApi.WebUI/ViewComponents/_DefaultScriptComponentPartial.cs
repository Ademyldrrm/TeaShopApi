using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
