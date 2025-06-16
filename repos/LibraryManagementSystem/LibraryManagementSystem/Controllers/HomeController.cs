using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        //print hello world 

        //public string Index()
        //{
        //     return "<font color='red'>Hello World!!</font>";
        //}
        //this method calls the view page(cshtml page)


        //public string India()
        //{
        //    return "Hello India!";
        //}
        public ViewResult Index()
        {
            //return View();
            string name = "birthday boy!";
            ViewData["a"] = name;
            ViewData["b"] = "we want party!!";
            ViewData["c"] = "we want grand party!!";

            ViewBag.hi = "mvc";

            TempData["t"] = "Lets Rock with MVC!!";
            TempData.Keep();
            return View();
        }
        public ViewResult Bank()
        {
            TempData.Keep();
            return View();
        }
        public ViewResult dance()
        {
            return View();
        }
        public string Service()
        {
            return "This is a Service page";
        }
        public string AboutUs()
        {
            return "AboutUs page";
        }

        public string India(int id)
        {
            return "THE ID YOU HAVE ENTERED IS" +id;
        }

        public string students(int id,string name,int age)
        {
            return $"the details you have entered are {id}{name}{age}";
        }

        //text/text treats html tags as text
        //text/html treates html tags as html tags not as a text
        public ContentResult cr()
        {
            return Content("<font color='red'><b>Hello world</b></font>","text/text");
        }

        public JavaScriptResult js()
        {
            var a = "alert('hello')";
            return JavaScript(a);
        }

        public JsonResult jsr()
        {
            return Json(new { Name = "Jayanth", age = 21, Address = "Chennai" },JsonRequestBehavior.AllowGet );
        }

        public EmptyResult empty() 
        {
            return new EmptyResult();
        }
        
        public RedirectResult redirecttoothersite()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectToRouteResult RedirectToAction()
        {
            return RedirectToAction("Index");
        }
        public HttpNotFoundResult NotFound()
        {
            return HttpNotFound("We didnot find that action,sorry!");
        }
        public FileResult testfile()
        {
            string contentType = "application/pdf";
            string filepath = @"C:\Files\UnitTest.pdf";
            return File(filepath, contentType,"UnitTest.pdf");
        }
        public FileResult GetFile()
        {
            return File(Url.Content("C:\\Files\\UnitTest.pdf"),"text/plain");
        }

        [ActionName("hw")]
        public string helloworld()
        {
            return "Hello world method called";
        }

        [ActionName("mp")]
        public ViewResult MyPage()
        {
            return View("MyPage");
        }

        [NonAction] //not possible to call from browser
        public string Hot()
        {
            return "Hot method called";
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        //to read the value of textboxes
        public ViewResult Add(FormCollection f)
        {
            int result = int.Parse(f["t1"]) + int.Parse(f["t2"]);
            ViewData["v"] = result;

            return View();
        }








    }
}