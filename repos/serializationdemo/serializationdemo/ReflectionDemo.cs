using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace serializationdemo
{
    internal class ReflectionDemo
    {
        [Obsolete("This method is deprecated pls use demo1new instead",true)]
        [Conditional("DEBUG")]
        public void Demo1()
        {
            Type t = typeof(string[]);
            Console.WriteLine(t.FullName); // Outputs: System.String
            Console.WriteLine(t.IsValueType);//false
            Console.WriteLine(t.IsAbstract);//false
            Console.WriteLine(t.IsArray);//true
            Console.WriteLine(t.IsSealed); //truehhhhhhhhhhhhhhhhhhhhhhhhhh 
        }
        public void Demo2()
        {
            // Get the Type object for MyClass
            Type myType = typeof(MyClass);
            Console.WriteLine($"Type Name: {myType.FullName}");
            Console.WriteLine($"Assembly Name: {myType.Assembly.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");
            Console.WriteLine($"Is Public: {myType.IsPublic}");
            Console.WriteLine($"Base Type: {myType.BaseType}");

            // Get Constructors
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = myType.GetConstructors();
            foreach (var ctor in constructors)
            {
                Console.WriteLine($"- {ctor}");
            }
            Console.WriteLine("===========");
            Console.WriteLine("Method Details");
            MemberInfo[] members = myType.GetMethods();

            foreach (var item in members)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("============================");
            Console.WriteLine("Properties Details");

            PropertyInfo[] p = myType.GetProperties();

            foreach (var item in p)
            {
                Console.WriteLine(item.Name);
            }
        }
        public void Demo3()
        {
            // Get the Type object for MyClass
            Type myType = typeof(PropertyInfo);
            Console.WriteLine($"Type Name: {myType.FullName}");
            Console.WriteLine($"Assembly Name: {myType.Assembly.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");
            Console.WriteLine($"Is Public: {myType.IsPublic}");
            Console.WriteLine($"Base Type: {myType.BaseType}");
        }
        public void Demo4()
        {
            //how to access methods and properties from dll 
            Console.WriteLine("enter the dll path");
            string data = Console.ReadLine();
            Assembly asm = Assembly.LoadFrom("d:\\mylib.dll");

            Type[] t = asm.GetTypes(); //members present inside namespaces

            foreach (var item in t)
            {
                Console.WriteLine(item.Name);//prints all class names
                Console.WriteLine("========");

                foreach(var i in item.GetMethods())
                {
                    Console.WriteLine(i.Name);//prints all method names
                }
            }

        }
        public void Demo5()
        {
            //activator.creates instances creates object dynamically
            //use this if the type is not ava at compile time 

            Assembly asm = Assembly.LoadFrom("d:\\mylib.dll");

            Type t =asm.GetType("mylib.mycls");

            //creates an object of mycls
            dynamic o = Activator.CreateInstance(t);
            o.Add(10, 20);

        }
    }
}
