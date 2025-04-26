using _01PC_PortfolioCore.Context;
using _01PC_PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class JobTitleController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.JobTitles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJobTitle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddJobTitle(JobTitle jobTitle)
        {
            context.JobTitles.Add(jobTitle);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteJobTitle(int id)
        {
            var value = context.JobTitles.Find(id);

            if (value != null)
                context.JobTitles.Remove(value);

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateJobTitle(int id)
        {
            var value = context.JobTitles.Find(id);

            if (value != null)
                return View(value);
            else
                return View();
        }

        [HttpPost]
        public IActionResult UpdateJobTitle(JobTitle jobTitle)
        {
            context.JobTitles.Update(jobTitle);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
