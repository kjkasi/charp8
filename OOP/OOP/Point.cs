using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point: GraphObject
    {
        public int X;
        public int Y;

        public Point (int X, int Y, string Color = DEFAULT_COLOR): base(Color)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Movedby(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine($"Point ({X}, {Y}), {Color}");
        }

    }
}
