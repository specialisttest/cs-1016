using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Circle : Shape
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Circle(int x, int y, int radius, string color = DEFAULT_COLOR)
            : base(color)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        private int radius;

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    this.radius = value;
                else
                    throw new ArgumentException("radius < 0");
            }

        }

        public override void Draw()
        {
            Console.WriteLine($"Circle ({X}, {Y}) {this.Radius} {Color}");
        }


    }
}
