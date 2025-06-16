using CodeFirstApp.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class MySongsController : Controller
    {
        SongContext dc;

        //the instance is retrieved from context file using DI
        public MySongsController(SongContext con)
        {
            dc = con;
        }
        public IActionResult Index()
        {
            var res = dc.Songs.ToList();
            return View(res);
        }

        public string Divide()
        {
            int a = 10;
            int b = 0;
            int c = a / b;
            return "the result is" + c;
        }
        public IActionResult Error()
        {
            //read current exception 
            var a = HttpContext.Features.Get<IExceptionHandlerFeature>();

            ViewData["m"] = "Message :"+a.Error.Message;

            ViewData["n"] = "Stack Trace :" + a.Error.StackTrace;

            ViewData["o"] = "Type :" + a.Error.Source;

            return View();
        }
        public IActionResult Mypage()
        {
            return View();
        }
    }
}
