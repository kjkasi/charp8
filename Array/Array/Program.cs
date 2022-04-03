using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");

            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[k];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.Write($"Введите {i} элемент массива: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Максимальное значение {arr.Max()}");
            Console.WriteLine($"Мининмальное значение {arr.Min()}");
            Console.WriteLine($"Среднее значение {arr.Average()}");

            Console.ReadKey();
        }
    }
}
