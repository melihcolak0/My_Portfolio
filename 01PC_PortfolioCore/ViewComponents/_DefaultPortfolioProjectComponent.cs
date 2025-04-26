using _01PC_PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultPortfolioProjectComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.Include(x => x.Category).ToList();
            return View(values);
        }
    }
}
