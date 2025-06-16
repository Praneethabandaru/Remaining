using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUNITDemo
{
    //genuine 
    public interface IMath
    {
        string Add(int x, int y); 

        public int Data { get; set; }
    }
    
    //internal class MyServiceCls : IMath
    //{
    //    public string Add(int x, int y)
    //    {
    //        int c = x + y;
    //        return "The Sum is " +c;
    //    }

    //}
}
