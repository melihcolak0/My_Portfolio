using Microsoft.AspNetCore.Mvc;

namespace _01PC_PortfolioCore.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderPartail()
        {
            return PartialView();
        }

        public PartialViewResult SideBarPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
