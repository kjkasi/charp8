using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class GraphObject : IColorfull
    {
        public const string DEFAULT_COLOR = "black";

        public static int SceneSize
        {
            get { return scene.Count; }
        }

        public abstract string Shape { get; }

        private protected string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        protected static List<GraphObject> scene = new List<GraphObject>();

        public static void DrawScene()
        {
            foreach (var g in scene)
                g.Draw();
        }

        public static void ScaleScene(string color)
        {
            foreach (GraphObject g in scene)
            {
                if (g is IColorfull)
                {
                    (g as IColorfull).Color = color;
                }
            }
        }

        public static void ScaleScene(double factor)
        {
            foreach (GraphObject g in scene)
            {
                if (g is IScaleable)
                {
                    ((IScaleable)g).Scale(factor);
                }
            }

        }

        public GraphObject(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
        }

        public abstract void Draw();
    }
}
