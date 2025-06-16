using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage
{
    internal class mm : IDisposable
    {
        public mm()
        {
            Console.WriteLine("Data connection is established ");
            //intiialize code
            Console.WriteLine("constructor called");
        }
        public void Add()
        {
            Console.WriteLine("added to the database");
            Console.WriteLine("Add  called");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);//stops calling destructor
            //code to destroy object
            Console.WriteLine("Dispose method called");
            Console.WriteLine("close a database connection");
        }

        public void sub()
        {
            Console.WriteLine("deleted from the database");
            Console.WriteLine("sub  called");
        }
        ~mm()
        {

            Console.WriteLine("Destructor is called");
            Console.WriteLine("close a database connection");
        }
    }
}
