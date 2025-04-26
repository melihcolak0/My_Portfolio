using _01PC_PortfolioCore.Context;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.ViewComponents
{
    public class _DefaultStatisticsComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        Random rnd = new Random();

        public IViewComponentResult Invoke()
        {
            ViewBag.testimonialCount = context.Testimonials.Count();
            ViewBag.portfolioCount = context.Portfolios.Count();
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.randomNumber = rnd.Next(10, 21);
            return View();
        }
    }
}
