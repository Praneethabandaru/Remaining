using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiondemo
{
    internal class assigndemo
    {
        public void Hashdemo()
        {
            //Develop a code to store list of country names in hashtable
            //The application should prompt the user to enter the key
            //If key is found, display its value else display appropriate error message
            //Hint use: ContainsKey() method
            int key;
            Hashtable h = new Hashtable();
            h.Add(1, "US");
            h.Add(2, "UK");
            h.Add(3, "INDIA");
            h.Add(4, "CANADA");
            Console.WriteLine("enter the key:");
            key = Convert.ToInt32(Console.ReadLine());
            if (h.ContainsKey(key))
            {
                Console.WriteLine(h[key]);
            }
            else
            {
                Console.WriteLine("key not found");
            }
        }
        List<customer> li = new List<customer>();
        public void listdemo()
        {
            //Develop a code to store customer details in list<> class
            
            customer c1 = new customer();
            c1.custid = 101;
            c1.custname = "praneetha";
            c1.address = "hyd";
            c1.DOB = Convert.ToDateTime("2002-02-01");
            li.Add(c1);
           
            customer c2 = new customer();
            c2.custid = 102;
            c2.custname = "potti";
            c2.address = "che";
            c2.DOB = Convert.ToDateTime("2002-08-14");
            li.Add(c2);

            //a. GetcustomerList() Lists all details of customers

            //b.GetReport(DateTime dt1 , DateTime dt2) : Lists all details between two dates

            //c. GetById(int cid) ): print customer details based on id
        }
        public void GetCustomerList()
        {
            foreach (var item in li)
            {
                Console.WriteLine(item.custid + ":" + item.custname + ":" + item.address + ":" + item.DOB);
            }
        }
        public void GetReport(DateTime dt1, DateTime dt2)
        {
            //List all details between two dates
            foreach (var item in li)
            {
                if (item.DOB >= dt1 && item.DOB <= dt2)
                {
                    Console.WriteLine(item.custid + ":" + item.custname + ":" + item.address + ":" + item.DOB);
                }
            }
        }
        public void GetById(int cid)
        {
            //print customer details based on id
            foreach (var item in li)
            {
                if (item.custid == cid)
                {
                    Console.WriteLine(item.custid + ":" + item.custname + ":" + item.address + ":" + item.DOB);
                }
            }
        }
    }
}
