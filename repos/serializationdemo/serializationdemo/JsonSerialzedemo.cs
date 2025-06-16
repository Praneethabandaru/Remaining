using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace serializationdemo
{
    internal class JsonSerialzedemo
    {
        public void SerializetoJson()
        {
            Customers c = new Customers()
            {
                id = 1,
                name="Darshan",
                age=30,
                address = "Blr"
            };

            string data = JsonSerializer.Serialize(c);
            File.WriteAllText("C:\\serialization\\customers.json", data);
            Console.WriteLine("Json file created");
        }
        public void DeserializeJson()
        {
            Customers c = new Customers();
            string data = File.ReadAllText("C:\\serialization\\customers.json");
            Customers obj=JsonSerializer.Deserialize<Customers>(data);
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj.age);
            Console.WriteLine(obj.address);
        }
    }
}
