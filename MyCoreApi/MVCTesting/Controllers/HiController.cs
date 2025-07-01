using Microsoft.AspNetCore.Mvc;

namespace MVCTesting.Controllers
{
    public class HiController : Controllers
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult First()
        {
            string[] st = { "", "" };
            return View(st);
        }
    }
}
