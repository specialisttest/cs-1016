using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
I.Лабораторная работа(наследование)
 * class Shape
 *      String Color
 *      Shape()
 *      Draw()
 * class Point : Shape
 * 		int X,Y
 * 		Point()
 * 		override Draw()
 * 		override string ToString()
 * 		MoveBy(int dx, int dy)
 * class Circle : Shape
 *      int X,Y
 *      Circle()
 *      override Draw()
 * 		override string ToString()
 * 		MoveBy(int dx, int dy)
 * 		Scale(double factor)
 * 	class Line : Shape
 * 	    int X1,Y1,X2,Y2
 * 	    Line()
 *      override Draw()
 * 		override string ToString()
 * 		MoveBy(int dx, int dy)
 * 		Scale(double factor)
 */


namespace OOP
{
    public class Circle : Shape, IScaleable, IScaleable3D
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
            Console.WriteLine(this); // Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Circle ({X}, {Y}) {this.Radius} {Color}";
        }

        /*// explicit implementation
        void IScaleable.Scale(double factor)
        {
            Radius = (int)Math.Round(Radius * factor);
        }*/

        //implicit implementation
        public void Scale(double factor)
        {
            Radius = (int)Math.Round(Radius / factor);
        }

        public void Scale3D(double factorX, double factorY, double factorZ)
        {
            
        }
    }
}
