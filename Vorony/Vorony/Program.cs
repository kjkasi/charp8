using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vorony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество ворон: ");
            int n = int.Parse(Console.ReadLine());

            string v;

            int n2 = n % 100;

            if (n2 >= 11 && n2 <= 14)
            {
                v = "ворон";
            }
            else
            {
                switch(n % 10)
                {
                    case 1: v = "ворона"; break;
                    case 2:
                    case 3:
                    case 4: v = "вороны"; break;
                    default: v = "ворон"; break;
                }
            }

            string result = $"На вертке {n} {v}";

            Console.WriteLine(result);
        }
    }
}
