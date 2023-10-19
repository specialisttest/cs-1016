using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Point : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }  

        public Point(int x, int y, string color = DEFAULT_COLOR)
            : base(color)
        {
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            // base.Draw(); // вызов метода родителя (если он реализован)
            Console.WriteLine($"Point ({X}, {Y}) {Color}");
        }

        public void MoveBy(int dx, int dy)
        { 
            X += dx;
            Y += dy;
        }
    }
}
