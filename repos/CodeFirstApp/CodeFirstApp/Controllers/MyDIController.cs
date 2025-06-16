using Microsoft.AspNetCore.Mvc;

namespace CodeFirstApp.Controllers
{
    public class MyDIController : Controller
    {
        //IMyinter obj=null;
        //public MyDIController(IServiceProvider sp)//this will receives the instance
        //public MyDIController(IMyinter m)//this will receives the instance
        //{
        //    obj = m;
        //    //obj = sp.GetKeyedService<IMyinter>("add");

        //}
        //[HttpGet]
        public IActionResult Di([FromServices]IMyinter m) //received instance directly to index method 
        {
            ViewData["res"] = m.AddNums(10, 20); 
            return View();
        }
        //[HttpPost]
        //public IActionResult Di(string num1, string num2)
        //{
        //    if (int.TryParse(num1, out int n1) && int.TryParse(num2, out int n2))
        //    {
        //        int sum = n1 + n2;
        //        ViewData["res"] = $"Result: {sum}";
        //    }
        //    else
        //    {
        //        ViewData["res"] = "Please enter valid numbers.";
        //    }
        //    return View();
        //} 
        public IActionResult methodhttp([FromServices] IMyinter m)
        {
            var services = this.HttpContext.RequestServices;
            var log =(IMyinter)services.GetService(typeof(IMyinter));

            log.AddNums(10, 20);

            return View();
        }

        
    }
}
