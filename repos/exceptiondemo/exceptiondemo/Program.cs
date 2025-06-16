using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            indexoutofrangedemo o = new indexoutofrangedemo();
            //o.demo1();
            //o.demo2();
            //o.demo3();
            //o.revstr();
            //o.demo4();

            Car basic = new BuilderDemo()
                        .CarName("alto")
                        .Color("red")
                        .RoofTop(false)
                        .WithAC(true)
                        .Price(500000)
                        .BuildCar();
            basic.DisplayCarInfo();

            Console.WriteLine("======");

            Car luxury = new BuilderDemo()
                        .CarName("BMW")
                        .Color("black")
                        .RoofTop(true)
                        .WithAC(true)
                        .Price(5000000)
                        .BuildCar();
            luxury.DisplayCarInfo();

            Console.WriteLine("====");

            Car car = new BuilderDemo()
                        .CarName("audi")
                        .Color("white")
                        .RoofTop(true)
                        .WithAC(false)
                        .Price(1000000)
                        .BuildCar();
           car.DisplayCarInfo();                                





        }
    }
}
