using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiondemo
{
    internal class Products //:IComparable
    { 
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }

        //public int CompareTo(object obj)
        //{
        //   Products p = (Products)obj;
        //   return pid.CompareTo(p.pid);

        //}
    }
}
