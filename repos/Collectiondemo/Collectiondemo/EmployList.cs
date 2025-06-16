using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collectiondemo
{
    internal class EmployList :IEnumerable
    {
        ArrayList ar = new ArrayList();
        public void AddEmp(string name)
        {
            ar.Add(name);
        }

        //indexers
        public object this[int index] // public string this[int index]  then return ar[index].ToString();
        {
            get {
                return ar[index]; 
            }
        }
        public void DisplayAll()
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ar.GetEnumerator();
        }
    }
}
