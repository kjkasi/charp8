using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Circle : GraphObject
    {
        public int X;
        public int Y;

        private int r;

        public override string Shape
        {
            get
            {
                return "Окружность";
            }
        }

        public virtual int R
        {
            get => r;

            private set
            {
                if (value > 0)
                    this.r = value;
                else
                    throw new ArgumentOutOfRangeException("r <= 0");
            }
        }

        public Circle(int X, int Y, int R, string Color = DEFAULT_COLOR)
            : base(Color)
        {
            this.X = X;
            this.Y = Y;
            this.R = R;
        }

        public static Circle Create(int X, int Y, int R, string Color = DEFAULT_COLOR)
        {
            Circle p = new Circle(X, Y, R, Color);
            GraphObject.scene.Add(p);
            return p;
        }

        public void Scale(double factor)
        {
            R = (int)(factor * R);
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X}, {Y}). R: {R}. {Color}");
        }

        public static explicit /*implicit*/ operator Point(Circle c)
        {
            return new Point(c.X, c.Y);
        }


    }
}
