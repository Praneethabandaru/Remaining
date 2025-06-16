using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystem.Models; // Assuming you have a Models folder with product.cs
namespace LibraryManagementSystem.Controllers
{
    public class MyShopController : Controller
    {
        // GET: MyShop
        myshopEntities m = new myshopEntities();
        public ActionResult Index()
        {
            //int i = 100;
            object obj = "MVC Rocks!!";
            var res = from t in m.products
                      select t;

            return View(res.ToList()); 
        }
        [HttpGet]
        public ActionResult GetById()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetById(string id)
        {
           var res = (from t in m.products
                      where t.pid == id
                      select t).FirstOrDefault();

            return View(res);
        }

        //accept id from textbox
        //print "total records delete is 1" when the user clicks
        //submit button

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Delete(string id)
        {
            var res = (from t in m.products
                       where t.pid == id
                       select t).FirstOrDefault();
            m.products.Remove(res); 
            int i =m.SaveChanges();
            return View(i);
        }

        public ActionResult Add()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Add(FormCollection frm)
        //{
        //    product p = new product();
        //    p.pid = frm["t1"];
        //    p.pname = frm["t2"];
        //    p.description = frm["t3"];
        //    p.price = Convert.ToInt32(frm["t4"]);
        //    p.pimage = frm["t5"];

        //    m.products.Add(p);
        //    int i = m.SaveChanges();
        //    return View(i); 
        //}

        [HttpPost]
        public ViewResult Add(product p ) //value comes automatically if all validation passes
        {
            if(ModelState.IsValid)
            {
                m.products.Add(p);
                int i = m.SaveChanges();
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}