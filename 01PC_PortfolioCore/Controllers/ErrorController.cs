using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Page404()
        {
            return View();
        }
    }
}
