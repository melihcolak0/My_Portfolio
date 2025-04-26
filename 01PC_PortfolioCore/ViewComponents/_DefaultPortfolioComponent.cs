using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultPortfolioComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
