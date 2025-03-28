using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class TestController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
    }
}
