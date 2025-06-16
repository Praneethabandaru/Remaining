using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class LinqDemo
    {
        public void Demo1()
        {
            string[] st = { "india", "singapore", "swiz", "uk" };
            
            var res = from t in st
                      where t.StartsWith("s")
                      select t;

            foreach (var t in res)
            {
                Console.WriteLine(t);
            }
        }
        public void Demo2()
        {
            int[] data = { 10, 11, 12, 13, 14, 15 };

            var res = from t in data
                      where t % 2 == 0 //where t.IsEven() we can use extension methods also
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public void Demo3()
        {
            List<Products> li = new List<Products>()
            {
                new Products() { pid = 100, pname = "Books", price = 220 },
                new Products() { pid = 101, pname = "Pen", price = 250  },
                new Products() { pid = 102, pname = "Pencil", price = 5000 },
                new Products() { pid = 103, pname = "Eraser", price = 10 },
                new Products() { pid = 104, pname = "Sharpner", price = 50 },
            };

            //var res = from t in li
            //          where t.price > 100 //(where is also optional)
            //          orderby t.price descending //orderby by default is ascending
            //          select t;

            //var res = from t in li
            //          where t.price > 50 && t.price < 200
            //          select t;

            //var res = from t in li
            //          select t; //here all the records wil get selected it act as *

            //var res = from t in li
            //          select new { t.pid, t.pname };

            //var res = from t in li
            //          select new { productid=t.pid, productname=t.pname }; //giving aias name for pid and pname

            //var res = from t in li
            //          where t.price > 300
            //          select t;

            var res =( from t in li
                      where t.price > 300
                      select t).ToList();

            li.Add(new Products() { pid = 105, pname = "bottle", price = 500 });

            foreach (var item in res)
            {
                 Console.WriteLine($"{item.pid} {item.pname} {item.price}");
                //Console.WriteLine($"{item.productid} {item.productname}");
            } 
        }
        public void Demo4()
        {

            //lamba expressions method
            List<Products> li = new List<Products>()
            {
                new Products() { pid = 100, pname = "Books", price = 220 },
                new Products() { pid = 101, pname = "Pen", price = 250  },
                new Products() { pid = 102, pname = "Pencil", price = 5000 },
                new Products() { pid = 103, pname = "Eraser", price = 60 },
                new Products() { pid = 104, pname = "Sharpner", price = 50 },
            };

            //query expression method
            //==================
            //var res = from t in li
            //          where t.price > 300
            //          select t;

            //lamba expression method
            //var res = li.Where(t => t.price > 300);

            //partition :take skip takewhile skipwhile

            //i want to print first 3 records
            //var res = li.Take(3); //prints 1st 3 records
            //var res = li.Skip(3); //skips 1st 3 records
            // var res=li.TakeWhile(t => t.price != 60); //it will take records until the condition is true
            //var res = li.SkipWhile(t => t.price != 60); //it skip records until the condition is true

            //supports chaining
            //var res = li.Take(5).Where(t => t.price > 500).Skip(1); 

            //1st 5 records  show price>1000 and print in desc
            //var res=li.Take(5).Where(t => t.price > 1000).OrderByDescending(t => t.price);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.pid} {item.pname} {item.price}");
            //}
            var res = li.Any(t => t.price > 1000); //it will return true if any record is present in the list
            Console.WriteLine(res);

            var res1=li.All(t => t.price > 1000); //it will return true if all the records are present in the list
            Console.WriteLine(res1);

            var res2=li.Contains (new Products() { pid = 100, pname = "Books", price = 220 }); //it will return true if the record is present in the list
            Console.WriteLine(res2);

            var r = li.Find(c => c.pid == 100); //it will return the record which is matching with the condition
            var res3 = li.Contains(r);
            Console.WriteLine(res3);


        }
        public void Demo5()
        {
            //linq opertions- Set operators (Except,intercept,union,distinct)
            int[] a = { 10, 20, 30, 40, 50,50 };
            int[] b = { 40, 50, 60, 70, 80 };

            //except
           //var res = a.Except(b); //it will give the records which are present in a but not in b
            //var res = a.Intersect(b);//it will give common records
            //var res = a.Union(b); //it will give the records which are present in a and b
           var res = a.Distinct(); //it will give the records which are distinct in a

            
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
        public void Demo6()
        {
            List<Products> li = new List<Products>()
            {
                new Products() { pid = 100, pname = "Books", price = 220 },
                new Products() { pid = 101, pname = "Pen", price = 250  },
                new Products() { pid = 102, pname = "Pencil", price = 5000 },
                new Products() { pid = 103, pname = "Eraser", price = 60 },
                new Products() { pid = 104, pname = "Sharpner", price = 50 },
            };
            //multiple courses are used to process the job
            var res = from t in li.AsParallel()
                      select t;

            //ienumerable:temporary object
            //(inmemory type of object)
            //examples:arrays,lists,collections,datasets
            //entire list is stores in the memory
            //example:
            //var res1=from t in li.AsQueryable()
            //         select t;

            //iquerable:if the user is working the databse
            //not inmemory (permanent data)
            //speciality : it will generate the sql query
            //it stores only selected records in the memory
            //example
            // var res = from t in li.AsParallel()
            //           select t;



            foreach (var item in res)
            {
                Console.WriteLine($"{item.pid} {item.pname} {item.price}");
            }


        }
    }
}
