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
        }
    }
}
