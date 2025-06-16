using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal abstract class sqldb
    {
        public string[] names;
        public abstract void connect();//the logic will be written in sub class
        //public virtual void connect()
        //{
        //    //logic to read from sql
        //    names=new string[] {"india","uk","sri lanka","swizterland"};
        //}
        public void filter()
        {
            //logic to filter 
            foreach (string name in names)
            {
                if(name.Contains("s"))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
    class oracledb :sqldb
    {
        public override void connect()
        {
            //logic to read from sql
            names = new string[] { "sydeny", "sri lanka", "uk" ,"swedan"};
        }
    }
    class mysqldb:sqldb
    {
        public override void connect()
        {
            names = new string[] { "singapore", "saudi", "uk", "south-africa" };
        }
    }
}
