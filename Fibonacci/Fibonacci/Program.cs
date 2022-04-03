using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k1 = 1;
            int k2 = 1;

            int k3;

            Console.WriteLine(k1);
            Console.WriteLine(k2);

            while ((k3 = k1 + k2) < 1000)
            {
                Console.WriteLine(k3);
                k1 = k2;
                k2 = k3;
            }
        }
    }
}
