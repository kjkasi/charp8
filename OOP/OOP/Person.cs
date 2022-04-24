using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public partial class Person : IComparable<Person>
    {
        public string Name { get; set; } = "Незнакомец";

        private int birthYear;
        public int Age
        {
            get
            {
                return DateTime.Now.Year - birthYear;
            }
            set
            {
                birthYear = DateTime.Now.Year - value;
            }
        }

        public static int counter;

        private string password;

        public string Password
        {
            set
            {
                password = value;
            }
        }


        public static void ShowCounter()
        {
            Console.WriteLine("Total persons: {0}", Person.counter);
        }

        public Person() : this("Unknow")
        {

        }

        public Person(string Name, int Age = 18)
        {
            this.Name = Name;
            this.Age = Age;
            counter++;
        }

        partial void Validate();

        public void Show()
        {
            Validate();
            Console.WriteLine("{0} - {1}", Name, this.Age);
        }

        public int CompareTo(Person p)
        {
            return this.Age - p.Age;
        }
    }
}
