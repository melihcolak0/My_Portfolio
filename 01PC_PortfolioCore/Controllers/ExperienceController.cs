using _01PC_PortfolioCore.Context;
using _01PC_PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult ListExperience()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ListExperience");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);

            if(value != null)
                context.Experiences.Remove(value);

            context.SaveChanges();
            return RedirectToAction("ListExperience");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);

            if (value != null)
                return View(value);
            else
                return View();

        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ListExperience");
        }
    }
}
