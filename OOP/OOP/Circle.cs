using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Circle: GraphObject
    {
        public int X;
        public int Y;
        public int R;

        public Circle (int X, int Y, int R, string Color = DEFAULT_COLOR): base(Color)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }

        public void Scale(double factor)
        {
            R= (int)(factor * R);
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X}, {Y}), R: {R}, {Color}");
        }

    }
}
