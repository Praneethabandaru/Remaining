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
    internal class serializationdemo
    {
        //Serialization is the process of converting an object into a format that can be stored or transmitted and reconstructed later.
        public void SerializationData()
        {
            //object is converted to file
            ArrayList li = new ArrayList();
            li.Add("Bubby");
            li.Add("Potti");
            li.Add("Mani");
            li.Add("Siva");
            li.Add("Teja");

            FileStream fs = new FileStream("C:\\serialization\\students.xml", FileMode.OpenOrCreate,FileAccess.ReadWrite);

            //type of data you want to serialize
            XmlSerializer xr = new XmlSerializer(typeof(ArrayList));
            xr.Serialize(fs, li);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("file created successfully");
        }
        public void deserailize() //system-2 
        {
            //file --> object (deconversion) 
            //file  object code goes here

            ArrayList ar = new ArrayList();
            FileStream fs = new FileStream("C:\\serialization\\students.xml", FileMode.OpenOrCreate,FileAccess.ReadWrite);

            XmlSerializer xr = new XmlSerializer(typeof(ArrayList));
            ar=(ArrayList)xr.Deserialize(fs);
            fs.Close();
            fs.Dispose();   

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total names present is : " +ar.Count);
        }
    }
}
