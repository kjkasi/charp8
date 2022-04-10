using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class GraphObject
    {
        public const string DEFAULT_COLOR = "black";
        public string Color;

        static List<GraphObject> scene = new List<GraphObject>();

        public static void DrawScene()
        {
            foreach (GraphObject obj in scene)
            {
                obj.Draw();
            }
        }

        public GraphObject(string Color = DEFAULT_COLOR)
        {
            this.Color = Color;
            scene.Add(this);
        }

        public virtual void Draw()
        {
            Console.WriteLine($"GraphObject. {this.Color}");
        }
    }
}
