using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializationdemo
{
    public class MyClass
    {
        public int PublicField = 10;
        private string privateField = "Secret";
        public string PublicProperty { get; set; } = "Default";
        private int PrivateProperty { get; set; } = 5;

        public MyClass() { }
        public MyClass(int value) { PublicField = value; }

        public void PublicMethod() { Console.WriteLine("Public method called."); }
        private void PrivateMethod(string message) { Console.WriteLine($"Private method: {message}"); }
    }
}
