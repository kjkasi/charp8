using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Point : GraphObject
    {
        public int X { get; set; } = 100;

        public int Y { get; set; }

        public int this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return X;
                    case 1: return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: X = value; break;
                    case 1: X = value; break;
                    default: throw new IndexOutOfRangeException();
                }

            }

        }
        public int this[string index]
        {
            get
            {
                switch (char.ToUpper(index[0]))
                {
                    case 'X': return X;
                    case 'Y': return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (char.ToUpper(index[0]))
                {
                    case 'X': X = value; break;
                    case 'Y': X = value; break;
                    default: throw new IndexOutOfRangeException();
                }

            }

        }

        public override string Shape
        {
            get
            {
                return "Точка";
            }
        }


        public Point(int X, int Y, string Color = DEFAULT_COLOR)
            : base(Color)
        {
            this.X = X;
            this.Y = Y;

        }

        public static Point create(int X, int Y, string Color = DEFAULT_COLOR)
        {
            Point p = new Point(X, Y, Color);
            GraphObject.scene.Add(p);
            return p;
        }

        public void MoveBy(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }

        public override void Draw()
        {
            Console.WriteLine($"Point ({X}, {Y}). {Color}");
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;
            if (!object.ReferenceEquals(p, null))
                return this.X == p.X && this.Y == p.Y;

            return false;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return object.Equals(p1, p2);
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }

        public override string ToString() => $"Point ({X}, {Y}). {Color}";
    }
}
