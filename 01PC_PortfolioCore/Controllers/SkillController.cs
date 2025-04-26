using _01PC_PortfolioCore.Context;
using _01PC_PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult ListSkill()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("ListSkill");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);

            if (value != null)
                context.Skills.Remove(value);

            context.SaveChanges();
            return RedirectToAction("ListSkill");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);

            if (value != null)
                return View(value);
            else
                return View();

        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Update(skill);
            context.SaveChanges();
            return RedirectToAction("ListSkill");
        }
    }
}
