using Microsoft.AspNetCore.Mvc;

namespace LogDemo.Controllers
{
    public class MyLogController : Controller
    {
        ILogger<MyLogController> l;
        public MyLogController(ILogger<MyLogController> logger)
        {
            l = logger;
        }

        public IActionResult Index()
        {
            //program => displays error:divideby0 any error
            //l.LogError("Attempt to divide by zero"); //meant for error msgs
            //l.LogWarning("Attempt to divide by zero"); //meant for warning msgs
            //l.LogInformation("Attempt to divide by zero"); //general msgs
            //l.LogCritical("Attempt to divide by zero");//system level logs like(sql notworking)

            //l.Log(LogLevel.Error, "Sql databse Not Working!!");

            //develop a code to log  1. error messagwes  (divide by zero)
            //2. date and time along with `error msgs 
            //3. log method name

            string actionName = RouteData.Values["action"]?.ToString();
            string controllerName = RouteData.Values["controller"]?.ToString();
            try
            {
                int a = 10, b = 0;
                int c = a / b; //this will throw an exception
            }
            catch (Exception ex)
            {
                l.LogError($"Error occured at {actionName} present in {controllerName} : with message {ex.Message} at {DateTime.Now}");
                      
            }
            return View();
        }
    }
}
