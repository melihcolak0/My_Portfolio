using _01PC_PortfolioCore.Context;
using _01PC_PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class DefaultController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            message.IsRead = false;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
