using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptiondemo
{
    class Car
    {
        public string CarName { get; set; }
        public bool RoofTop { get; set; }
        public bool WithAC { get; set; }
        public string Color { get; set; }

        public double Price { get; set; }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"CarName : {CarName}");
            Console.WriteLine($"color : {Color}");
            Console.WriteLine($"RoofTop : {(RoofTop ? "WithRoof":"WithOutRoof")}");
            Console.WriteLine($"AC : {(WithAC  ? " WithAc" : "WithOutAc")}");
            Console.WriteLine($"Price : {Price}");
        }

    }
    internal class BuilderDemo
    {
        Car c = new Car();
        public BuilderDemo CarName(string name )
        {
            c.CarName = name;
            return this;
        }
        public BuilderDemo Color(string color)
        {
            c.Color = color;
            return this;
        }
        public BuilderDemo RoofTop(bool roof)
        {
            c.RoofTop = roof;
            return this;
        }
        public BuilderDemo WithAC(bool ac)
        {
            c.WithAC = ac;
            return this;
        }
        public BuilderDemo Price(double price)
        {
            c.Price = price;
            return this;
        }
        public Car BuildCar()
        {
            return c;
        }
    }
    
        
    
}
