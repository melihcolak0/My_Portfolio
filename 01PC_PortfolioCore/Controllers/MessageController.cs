using _01PC_PortfolioCore.Context;
using _01PC_PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMessage(Message message)
        {
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);

            if (value != null)
                context.Messages.Remove(value);

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var value = context.Messages.Find(id);

            if (value != null)
                return View(value);
            else
                return View();

        }

        [HttpPost]
        public IActionResult UpdateMessage(Message message)
        {
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Update(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MakeMessageRead(int id)
        {
            var value = context.Messages.Find(id);

            if (value != null)
            {
                value.IsRead = true;
                context.Messages.Update(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public IActionResult MakeMessageUnRead(int id)
        {
            var value = context.Messages.Find(id);

            if (value != null)
            {
                value.IsRead = false;
                context.Messages.Update(value);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
