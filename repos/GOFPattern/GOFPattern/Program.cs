using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to call singleton class
            //var ob = Singleton.Instance;
            //ob.Method();

            //how to call factory instance
            //factory ob = new factory();
            //var ob1 = ob.GetInstance(3);
            //var data = ob1.ShowData();
            //foreach ( var item in data )
            //{
            //    Console.WriteLine(item);
            //}

            //how to access prototype object
            //Circle ob = new Circle();
            //ob.Radius = 10;
            //ob.Color = "red";
            //ob.Draw();             

            //Circle ob1 = new Circle();
            //ob1 = (Circle)ob.Clone();
            //ob1.Color = "blue";
            //ob.Draw();
            //ob1.Draw();

            //Console.ReadLine();

            //how to call adapter object
            //how to access older printer and new printer using interface
            //IPrinter p = new ModernPrinter();
            //p.Print("hello world");

            //LegacyPrinter o = new LegacyPrinter();
            //IPrinter p2 = new LegacyPrinterAdapter(o);
            //p2.Print("good afternoon");

            //first time 
            //--------------
            //login l = new login();
            //l.checkuser();

            //product p = new product();
            //p.addtocart();

            //sendmail s = new sendmail();
            //s.mailtouser();

            //makepayment m = new makepayment();
            //m.processpayment();                                                                                                              

            //Console.WriteLine("===============");
            ////SECOND TIME 
            //facadepattern f = new facadepattern();
            //f.buyproduct();
            //Console.Read();

            //books ob = new onlinedelivery();
            //ob.ProcessData();
            //Console.WriteLine("========");
            //books ob1= new physicaldelivery();
            //ob1.ProcessData();

            NotificationService notificationService = new NotificationService();

            User user1 = new User("Appu");
            User user2 = new User("Bubby");
            User user3 = new User("Mani");
            User user4 = new User("Potti");

            notificationService.Subscribe(user1);
            notificationService.Subscribe(user2);
            notificationService.Subscribe(user3);
            notificationService.Subscribe(user4);

            notificationService.NotifyObservers("Get Ready for exam on monday");
            Console.WriteLine("==========");
            notificationService.Unsubscribe(user4);

            notificationService.NotifyObservers("have a great day!!");
            //notificationService.NotifyObservers("New message available!");
            //Console.Read();


        }
    }
}
