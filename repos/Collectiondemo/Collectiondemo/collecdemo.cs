using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collectiondemo
{
    internal class collecdemo
    {
        public void arraylistdemo1()
        {
            ArrayList al = new ArrayList();
            al.Add("india");
            al.Add("canada");
            al.Add("uk");
            al.Add(100);
            al.Add(true);

            //how do you access individual value?
            Console.WriteLine(al[1]);

            //how do you print all values?
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            //how do you find the total items in the arraylist?
            Console.WriteLine("Total items in the arraylist: " + al.Count);

            //how do you insert value at specific postiton?
            al.Insert(1, "usa");
            Console.WriteLine("=====");

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============");
        }
        public void arraylistdemo2()
        {
            //what is capacity property?
            //capacity is the number of elements that the arraylist can hold before it needs to resize.
            ArrayList al = new ArrayList(10);
            al.Add("praneetha"); //got op :4 
            al.Add("praneetha");
            al.Add("praneetha");
            al.Add("praneetha");
            al.Add("praneetha"); //here we are adding 5th element though the size is 4 ,then the size has increased to 8
            al.Capacity = 15; //here we are setting the capacity to 15
            al.TrimToSize(); //this will remove the extra space in the arraylist
            //it can show you no of items  arraylist can store
            Console.WriteLine(al.Capacity); //here the default is 4 
        }
        public void arraylistdemo3()
        {
            //arraylist in realtime
            //how to store product details 
            ArrayList ar = new ArrayList();
            Products p1 = new Products();
            p1.pid = 100;
            p1.pname = "Books";
            p1.price = 120;

            ar.Add(p1);

            Products p2 = new Products();
            p2.pid = 101;
            p2.pname = "Pen";
            p2.price = 20;
            ar.Add(p2);

            //view cart logic
            //another method for adding the data (Method-2)
            Products p3 = new Products() { price = 200, pid = 102, pname = "Pencil" };
            ar.Add(p3);

            //Method-3
            ar.Add(new Products() { price = 300, pid = 103, pname = "Eraser" });

            foreach (Products i in ar) //dont use var in this bcz it wont print anything
            {
                Console.WriteLine(i.pid +":" +i.pname +":" +i.price);
            }
        }
        public void arraylistdemo4()
        {
            //Method-4

            // Correct way to initialize an ArrayList with objects 

            //collection initializer syntax
            ArrayList ar = new ArrayList
             {
                new Products() { pid = 5000, pname = "lap", price = 2000 },
                new Products() { pid = 60, pname = "laptt", price = 2000 },
                new Products() { pid = 700, pname = "laptop", price = 2000 }
             };

            mysortcls obb = new mysortcls();
            ar.Sort(obb);

            //ar.Sort(); 
            // Iterate over the ArrayList and print product details
            foreach (Products i in ar)
            {
                Console.WriteLine(i.pid + ":" + i.pname + ":" + i.price);
            }
        }
        public void arraylistdemo5()
        {
            //how sorting works?

            ArrayList ar = new ArrayList();
            ar.Add(100);
            ar.Add(50);
            ar.Add(30);
            ar.Add(70);

            ar.Sort(); //this will sort the arraylist in ascending order by default
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            } 
        }
        public void Hashtabledemo()
        { 
            //use hashtable for larger data for searching and sorting 
            Hashtable h = new Hashtable();
            h.Add("100", "india");
            h.Add("27", "canada");
            h.Add("35", "uk");
            h.Add("4555", "usa"); 
            SortedList sr = new SortedList(h);
              
            foreach (DictionaryEntry item in sr)
            {
                Console.WriteLine(item.Key+":"+item.Value);
                //Console.WriteLine();
            }
        }
        public void stackdmeo()
        {
            Stack s = new Stack();
            s.Push("http://google.com");
            s.Push("http://youtube.com");
            s.Push("http://facebook.com");

            //pop method
            Console.WriteLine(s.Pop()); //remove +print 
            Console.WriteLine(s.Peek()); //it will prints the top element of the stack without removing it     
            Console.WriteLine("======");

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
        public void qdemo()
        {
            Queue q = new Queue();
            q.Enqueue("rahul");
            q.Enqueue("rowdy");
            q.Enqueue("ravi");
            q.Enqueue("mani");

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            Console.WriteLine("========");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
        public void listdemo()
        {
            //ArrayList ar =new ArrayList();
            //ar.Add(10);
            //ar.Add(20);
            //ar.Add(30);
            //int c = Convert.ToInt32(ar[0]) + Convert.ToInt32(ar[2]);
            //Console.WriteLine(c);

            List<int> li = new List<int>();
            li.Add(10); //checks at compile time
            li.Add(20); 
            li.Add(30);
            int c = li[0] + li[1]; //typecasting not required
            Console.WriteLine(c);
        }
        public void dictionarydemo()
        {
            //creating a dictionary list to store country names key:int and value:string
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "india");
            d.Add(2, "uk");
            d.Add(3, "usa");
            d.Add(4, "canada");
            foreach (KeyValuePair<int, string> item in d)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
        }
        public void listdemo1()
        {
            //create a list to store product details
            //print all details where price > 120

            List<Products> li = new List<Products>();
            li.Add(new Products() { pid = 100, pname = "Books", price = 120 });
            li.Add(new Products() { pid = 101, pname = "Pen", price = 20 });
            li.Add(new Products() { pid = 102, pname = "Pencil", price = 200 });

            foreach (Products item in li)
            {
                if (item.price > 120)
                {
                    Console.WriteLine(item.pid + ":" + item.pname + ":" + item.price);
                }
            }
        }
    }

    class mysortcls : IComparer
    {
        public int Compare(object x, object y)
        {
            Products p1 = (Products)x;
            Products p2 = (Products)y;
            return p1.pid.CompareTo(p2.pid);
        }
    }
}
