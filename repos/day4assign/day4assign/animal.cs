using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4assign
{
    internal class animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("animal makes diff sounds");
        }
    } 
    class Dog :animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("dog sound:bow-bow");
        }
    }
    class Cat :animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("cat sound:meow-meow");
        }
    }
}
