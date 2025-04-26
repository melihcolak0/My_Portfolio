using _01PC_PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultExperienceComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext(); 

        public IViewComponentResult Invoke()
        {
            var value = context.Experiences.ToList();
            return View(value);
        }
    }
}
