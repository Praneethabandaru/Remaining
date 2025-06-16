using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    internal class Myorders
    {
        b248dbEntities ob = new b248dbEntities();
        public void displayorders()
        {
            var res = from t in ob.orders 
                      select t;

            foreach (var item in res)
            {
                Console.WriteLine($"{item.orderid} {item.orderdate} {item.orderlocation} {item.productname} {item.custid}");
            }
        }
 
        public void commonrecord()
        {
            //1.write a linq query to display common record from customers and orders 
            var res = from t2 in ob.orders join t1 in ob.customers
                      on t2.custid equals t1.custid
                      select new 
                      { 
                          t1.custid,
                          t1.custname,
                          t1.dob,
                          t1.caddress,
                          t1.cphone,
                          t2.orderdate,
                          t2.productname,
                          t2.orderlocation,
                          t2.orderid
                      };
            foreach (var item in res)
            {
                Console.WriteLine($"{item.orderid} {item.orderdate} {item.orderlocation} {item.productname} {item.custid}");
            }
        }
        public void displaytop3customers()
        {
            //write a linq query to display top 3 highest orders made customers 
            var res = from o in ob.orders
                      orderby o.price descending
                      select o;
            var top3 = res.Take(3);
            foreach (var item in top3)
            {
                Console.WriteLine($"{item.orderid} {item.orderdate} {item.orderlocation} {item.productname} {item.custid} {item.price}");
            }
        }
        public void maxprice()
        {
            //3.write a linq query to find the max price and group by custid in orders table 
            var res = from o in ob.orders
                      group o by o.custid into groupedOrders
                      select new
                      {
                          CustomerID = groupedOrders.Key,
                          MaxPrice = groupedOrders.Max(o => o.price) // Find max price for each customer
                      };
            foreach (var item in res)
            {
                Console.WriteLine($"CustId : {item.CustomerID},Max Price : {item.MaxPrice}");
            }
        }
        public void displayCustomersWithoutOrders()
        {
            //4.display the list of customers who have not made any orders 
            var res = from c in ob.customers
                      where !ob.orders.Any(o => o.custid == c.custid)
                      select c;
            foreach (var item in res)
            {
                Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
            }
        }
        public void displayaddressblr()
        {
            //5. DISPLAY THE LIST FROM ORDERS TABLE WHO'S CADDRESS = 'banglore' and display the details in uppercase
            var res = from c in ob.customers
                      where c.caddress == "banglore"
                      select new
                      {
                          c.custid,
                          CustomerName = c.custname.ToUpper(),
                          c.dob,
                          c.caddress,
                          c.cphone
                      };
            foreach (var item in res)
            {
                Console.WriteLine($"{item.custid} {item.CustomerName} {item.dob} {item.caddress} {item.cphone}");
            } 
        }
        public void displayIncreaseprice()
        {
            //display what each price would be if a 20% price increase were to take place.Show the custid,old price and new price(use orders table)
            var res = from o in ob.orders
                      select new
                      {
                          o.custid,
                          OldPrice = o.price,
                          NewPrice = o.price + o.price * (0.2)
                      };
            foreach (var item in res)
            {
                Console.WriteLine($"Old Price : {item.OldPrice} , NewPrice : {item.NewPrice}");
            }
        }
        public void customersbirthday()
        {
            var today = DateTime.Today;
            //display the list of customers who's birthdate is today 
            var res = from c in ob.customers
                      where c.dob.HasValue && c.dob.Value.Day == DateTime.Now.Day
                      select new
                      {
                          c.custid,
                          c.custname,
                          c.dob, // Format explicitly
                          c.caddress,
                          c.cphone
                      };

            foreach (var item in res)
            {
                Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
            }
        }
        public void december()
        {
            //display those orders who made orders in december of any year 
            var res = from x in ob.customers
                      where x.dob.Value.Month == 12
                      select new
                      {
                          x.custid,
                          x.custname,
                          x.dob, // Format explicitly
                          x.caddress,
                          x.cphone// Assuming there's a field for order total
                      };

            foreach (var item in res)
            {
                Console.WriteLine($"{item.custid} {item.custname} {item.dob} {item.caddress} {item.cphone}");
            }
        }
    }
}
