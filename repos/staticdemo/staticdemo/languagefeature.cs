using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticdemo
{ 
    class x1
    {
        public void hi()
        {
            Console.WriteLine("hi called");
        }
    }
    internal class languagefeature
    {
        dynamic s;
        public void display()
        {
#pragma warning disable 
            int m;
#pragma warning restore
            int n;
            x1 ob = new x1();
            ob.hi();

            global::x1 obb = new global::x1();
            obb.hello();
        }
        public Tuple<int, string> getdata() //max is 8 if we want to use more than 8 then need to nest the tuple public Tuple <int ,Tuple<>>
        {
            string name = "potti";
            int age = 23;
            Tuple<int, string> t = new Tuple<int, string>(age, name);
            return t;
        }
        public void implicittyped()
        {
            int a = 10;
            string s = "hello";

            var m = 10;
            var n = "hi";
            var b = true;
            //var e = null;

            int g;
            g = 10;

            //var k;
            //k = 10;
            var r = "hello";
            dynamic f = 7;

            int d,k,i;
        }
        public void dynamicdemo(dynamic d1)
        {
            //var s = 10;
            //s = "hi";

            dynamic d;
            d = "hi";
            Console.WriteLine(d);
            d = 10;
            Console.WriteLine(d);
            d=true;
            Console.WriteLine(d);
            
        }
            
    }
    static class myexcls
    {
        public static bool IsEven(this int x)
        {
            return x % 2 == 0;
        }
        public static int  tointeger(this string x)
        {
            return int.Parse(x);
        }
        public static int add(this x1 obj,int x, int y)
        {
            return x + y;
        }

    }
}
class x1
{
    public void hello()
    {
        Console.WriteLine("hello called");
    }
   
}
