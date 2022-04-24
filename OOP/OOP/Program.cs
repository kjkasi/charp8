using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public partial class Person
    {
        public class Validator
        {

            protected bool isChecked = false;

            public void Validate(Person p)
            {
                Console.WriteLine("Validating person: {0} with birth {1}",
                    p, p.birthYear);
            }
        }


        public string EMail { get; set; }

        partial void Validate()
        {
            var v = new Validator();
            v.Validate(this);

        }

        public override string ToString() => $"{Name} : {Age} ({EMail})";
    }

internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 =
                    new Person("Сергей", 42) { EMail = "sshuykov@specialist.ru" };

            Console.WriteLine(p1.Age);


            Person p2 = new Person("Костя", 14); 

            Person px = new Person();
            Person.Validator v = new Person.Validator();
            v.Validate(px);

        }
    }
}
