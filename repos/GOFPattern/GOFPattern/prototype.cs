using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern
{
    public interface IShape
    {
        void Draw();
    }

    // Concrete Prototype
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public string Color { get; set; }

        public object Clone()
        {
            //returns new objects having original data
            return this.MemberwiseClone(); // Shallow copy
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a {Color} circle with radius {Radius}");
        }
    }
}
