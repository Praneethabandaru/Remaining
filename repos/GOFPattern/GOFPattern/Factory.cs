using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOFPattern
{
    interface Mydb
    {
        string[] ShowData();
    }
    internal class Sqldata : Mydb
    {
        public string[] ShowData()
        {
            string[] data = { "india", "canada", "uk" };
            return data;
        }
    }
    internal class Oracledata : Mydb
    {
        public string[] ShowData()
        {
            string[] data = { "CSK", "RCB", "SRH" };
            return data;
        }
    }
    internal class mysqldata : Mydb
    {
        public string[] ShowData()
        {
            string[] data = { "html", "css", "js" };
            return data;
        }
    }

    class factory
    {
        //return the instance based upon the input
        public Mydb GetInstance(int i)
        {
            //if user passes 1 ,return sql data 
            //is user passes 2,return oracle data

            if(i==1)
            {
                return new Sqldata();
            }
           if(i==2) 
            {
                return new Oracledata();    
            }
            else
            {
                return new mysqldata();
            }
        }
    }
}
