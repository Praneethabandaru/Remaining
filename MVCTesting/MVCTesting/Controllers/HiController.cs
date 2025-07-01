using Microsoft.AspNetCore.Mvc;

namespace MVCTesting.Controllers
{
    public class HiController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult About()
        {
            string[] st = { "", "" };
            return View("About");
        }
        public IActionResult First()
        {
            string[] st = {"",""};
            return View(st);
        }
        public RedirectToActionResult Second() 
        { 
            return RedirectToAction("Index");
        }

    }
}
