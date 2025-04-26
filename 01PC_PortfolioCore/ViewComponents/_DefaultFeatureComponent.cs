using _01PC_PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultFeatureComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.JobTitles.ToList();            
            return View(values);
        }
    }
}
