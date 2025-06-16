using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal interface Ishape
    {
        void CalculateArea();
    }
    class circle : Ishape
    {
       public void CalculateArea()
        {
            int radius=5; 
            Console.WriteLine("Area of circle:" +((3.14) * (radius) * (radius)));
        }
    }
    class rectangle : Ishape
    {
        public void CalculateArea()
        {
            int l = 12;
            int b=122;

            Console.WriteLine("Area of Rectangle:" + (l * b));
        }
    }
}
