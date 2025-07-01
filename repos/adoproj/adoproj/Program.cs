using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace adoproj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConnectedDemo ob = new ConnectedDemo();  
            //ob.Displaycustomers();  
            //ob.Displaycustomers1();  
            //ob.InsertCustomer();  
            //ob.InsertingCustDynamically();  
            //ob.DeleteCustomer();  
            //ob.Getbyid();  
            //ob.UpdateCustomer();  
            //ob.DisplayCustomersbyproc();  
            //ob.displaymultiple();  
           DisConnectedDemo ob = new DisConnectedDemo();
            //ob.displaycustomer();
            //ob.Search();
            //ob.Insert();
            //ob.Delete();
            //ob.update();
            //ob.generatexml();
            //ob.generatexmlwithchanges();
            //ob.getchanges();
            //ob.convertreadertotable();
            //ob.readonlytable();
            //ob.copy();
           // DisconnectedAdvanced obb = new DisconnectedAdvanced();
            //obb.Demo1();
           // obb.Demo2();
            //obb.demo3();
           // Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new transactiond());
            Application.Run(new Form3());




        }
    }
}
