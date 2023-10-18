using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public partial class Person
    {
        public string Name = "Неизвестный";
        public int Age;

        private static int counter = 0;

        public static void PrintTotal()
        {
            Console.WriteLine($"Total persons: {Person.counter}");
        }

        public Person() : this("Неизвестный", 18)
        {
            //this.Age = 18;
        }

        //public Person(string Name)
        //    : this(Name, 33) { }

        public Person(string Name, int Age = 33)
        { 
            this.Name = Name;
            this.Age = Age;
            //Person.counter++;
            counter++;
        }

        // private 
        partial void Validate();

        public void Show()
        {
            Validate();
            Console.WriteLine("{0} - {1}", this.Name, Age);
        }

        ~Person()
        {
            Console.WriteLine("~Person()");
        
        }

    }
}
