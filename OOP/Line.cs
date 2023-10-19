using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Line : Shape, IScaleable
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Line(int x1, int y1, int x2, int y2, string color = DEFAULT_COLOR)
            : base( color )
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public override void Draw()
        {
            Console.WriteLine($"Line from ({X1}, {Y1}) to ({X2}, {Y2}) {Color}");
        }

        public void MoveBy(int dx, int dy)
        { 
            X1 += dx;
            X2 += dx;
            Y1 += dy;
            Y2 += dy;
        }
        public void Scale(double factor)
        {
            X2 = (int)Math.Round((X2 - X1) * factor) + X1;
            Y2 = (int)Math.Round((Y2 - Y1) * factor) + Y1;
        }

    }
}
