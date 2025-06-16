using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Address
    {
        public string City;
    }
    class Person
    {
        public string Name;
        public int Age;
        public Address Address;

        public Person() { }
        // Copy Constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
            Address = new Address { City = other.Address.City }; // Deep copy of reference type

        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} address : {Address.City}");
        }
    }
 }
