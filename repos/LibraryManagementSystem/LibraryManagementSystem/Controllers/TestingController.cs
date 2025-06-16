using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class TestingController : Controller
    {
       public ViewResult ShowSum()
       {
            int[] data = { 3, 45, 43, 3, 23 };
            ViewData["t"] = data;
            ViewBag.a = data;

            return View();

       }

        public ViewResult PrintALLNames()
        {
            string[] Names = { "Rohit", "sachin", "Dhoni", "Virat", "Raina" };
            ViewData["Names"] = Names;
            ViewBag.a=Names;

            return View();
        }

        public ViewResult AcceptNPrint(int num)
        {
            List<string> names = new List<string>();
            for (int i = 0; i < num; i++)
            {
                names.Add("Rohith");

            }
            ViewBag.a = names;
            ViewBag.b = num;
            return View();
        }
    }
}