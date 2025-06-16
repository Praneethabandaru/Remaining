using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNITDemo
{
    internal class FakeClass : IMath
    {
        public int Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //minimum code is return to pass the test 
        //you may not use real database or file
        //instead you might use face db or fake file
        public string Add(int x,int y)
        {
            return $"the sum is {x + y}";
        }
    }
}
