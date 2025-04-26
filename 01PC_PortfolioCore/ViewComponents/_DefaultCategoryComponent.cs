using _01PC_PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultCategoryComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}
