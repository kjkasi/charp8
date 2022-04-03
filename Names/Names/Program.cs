using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    names.Add(name);
                }
                else
                {
                    break;
                }
            }

            names.Sort();

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
