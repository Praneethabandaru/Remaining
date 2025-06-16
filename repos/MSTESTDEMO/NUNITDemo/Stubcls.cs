using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNITDemo
{
    internal class Stubcls : IMath
    {
        public int Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Add(int x, int y)
        {
            return "the sum is 30";
        }
    }
}
