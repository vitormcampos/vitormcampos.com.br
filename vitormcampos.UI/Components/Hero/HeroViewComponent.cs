using Microsoft.AspNetCore.Mvc;

namespace vitormcampos.com.br.UI.Components
{
    public class HeroViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Components/Hero/Default.cshtml");
        }
    }
}
