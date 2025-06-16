using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace serializationdemo
{
    internal class binaryserializerdemo
    {
        public void binaryserialize()
        {
            ArrayList li = new ArrayList();
            li.Add("Teja");
            li.Add("Sailu");
            li.Add("Gagan");
            li.Add("Pandi");

            FileStream fs = new FileStream("C:\\serialization\\friends.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, li);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("file created!!!!!");
        }
        public void binarydeserialize()
        {
            ArrayList ar = new ArrayList();
            FileStream fs = new FileStream("C:\\serialization\\friends.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            ar = (ArrayList)bf.Deserialize(fs);
            fs.Close();
            fs.Dispose();

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total names present is : " + ar.Count);
        }
    }
}
