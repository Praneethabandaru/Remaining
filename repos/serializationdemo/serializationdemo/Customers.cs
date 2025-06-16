using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace serializationdemo
{
    public  class Customers
    {
        //id as an attribute
        //i dont want to store address in file

        [XmlAttribute]
        public int id {  get; set; }
        public string name { get; set; }
        public int age { get; set; }
        [XmlIgnore]
        public string address { get; set; }

       public void serializedata()
       {
            List<Customers> c = new List<Customers>
            {
               new Customers { id = 1, name = "Bubby", age = 23, address = "Hyd" },
               new Customers {id=2, name = "Potti", age = 24, address = "Hyd" }
            };

            FileStream fs = new FileStream("C:\\serialization\\customers.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //type of data you want to serialize
            XmlSerializer xr = new XmlSerializer(typeof(List<Customers>));
            xr.Serialize(fs, c);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("file createdd");
       }
       public void deserailize()
        {
            FileStream fs = new FileStream("C:\\serialization\\customers.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            XmlSerializer xr = new XmlSerializer(typeof(List<Customers>));
            List<Customers> c = (List<Customers>)xr.Deserialize(fs);
            fs.Close();
            foreach (Customers a in c)
            {
                Console.WriteLine(a.name +" "+a.id+" "+a.age);
            }
        }

    }
    
}
