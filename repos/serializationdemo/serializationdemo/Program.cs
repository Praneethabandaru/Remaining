using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serializationdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //serializationdemo s = new serializationdemo();
            //s.SerializationData();
            //s.deserailize();

            //Customers c = new Customers();
            //c.serializedata();
            //c.deserailize();

            //binaryserializerdemo b = new binaryserializerdemo();
            //b.binaryserialize();
            //b.binarydeserialize();

            //JsonSerialzedemo d = new JsonSerialzedemo();
            //d.SerializetoJson();
            //d.DeserializeJson();

            //Originator originator = new Originator();
            //Caretaker caretaker = new Caretaker();

            //originator.State = "Initial State";
            //Console.WriteLine("State set to: " + originator.State);

            //Memento savedState = originator.SaveState();
            //caretaker.SaveToXml(savedState, "memento.xml");

            //originator.State = "Modified State";
            //Console.WriteLine("State changed to: " + originator.State);

            //// Restore from XML
            //Memento restoredState = caretaker.LoadFromXml("memento.xml");
            //originator.RestoreState(restoredState);
            //Console.WriteLine("State restored to: " + originator.State);

            ReflectionDemo r = new ReflectionDemo();
            r.Demo1();
            //r.Demo2();
            //r.Demo3();
            r.Demo4();
            r.Demo5();
        }
    }
}
