using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5, 6, 10, "Red");
            c1.Scale(0.75);
            //c1.Draw();

            GraphObject.DrawScene();
            GraphObject.ColorScene("Blue");
            GraphObject.DrawScene();

            BankAccount b1 = new BankAccount("Sergey");
            BankAccount b2 = new BankAccount("Alex");
            b1.Deposit(1000);
            BankAccount.Transfer(b1, b2, 300);

            Console.WriteLine(b1);
            Console.WriteLine(b2);

        }
    }
}
