using Microsoft.AspNetCore.Mvc;

namespace vitormcampos.com.br.UI.Components
{
    public class AboutViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("/Components/About/Default.cshtml");
        }
    }
}
