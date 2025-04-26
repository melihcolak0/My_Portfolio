using _01PC_PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultSkillComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
