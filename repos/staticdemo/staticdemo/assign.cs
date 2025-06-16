using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace staticdemo
{
    internal class assign
    {
        public Tuple<string> SplitfullName(string fullName)
        {
            string name = "John doe";
            Tuple<string> s = new Tuple<string>(fullName);
            string[] names = fullName.Split(' ');
            string firstName = names[0];
            string lastName = names[1];
            Console.WriteLine(firstName+" ");
            Console.WriteLine(lastName);
            return s;
        }
    }
}
