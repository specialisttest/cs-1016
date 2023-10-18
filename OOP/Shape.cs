using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Shape
    {
        public const string DEFAULT_COLOR = "black";
        public string Color { get; set; }
        public Shape(string color = DEFAULT_COLOR)
        {
            Color = color;
        }

        public abstract void Draw();

        /*public virtual void Draw()
        {
            //Console.WriteLine($"Shape. {Color}");
        }*/
    }
}
