using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDemo
{
    internal class GenRepo
    {
        b248dbEntities dc = new b248dbEntities();
        public void Insert<T>(T item) where T : class
        {

            dc.Set<T>().Add(item); //dc.customer.add(c);
            int i = dc.SaveChanges();
            Console.WriteLine("total no of rows inserted is "+i);
        }
        public void Delete<T>(T item) where T : class
        {
            dc.Set<T>().Attach(item);
            dc.Set<T>().Remove(item);
            int i = dc.SaveChanges();
            Console.WriteLine("Total no of rows deleted is" +i);
        }
        public T Find<T>(int item) where T : class
        {
            return dc.Set<T>().Find(item);
        }
        public IQueryable<T> top3<T>(int item) where T : class
        {
            return dc.Set<T>().Take(item);
        }
    }
}
