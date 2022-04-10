using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureTypes
{
    struct Person
    {
        public string Name;
        public int? Age;

        public Person(string Name, int? Age = null)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void Show()
        {
            if (Age != null)
            {
                Console.WriteLine($"{Name} - {Age}");
            }
            else
            {
                Console.WriteLine($"{Name}");
            }
            
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Sergey", 42);
            p1.Show();
            Person p2 = new Person("Andrey");
            p2.Show();
        }
    }
}
