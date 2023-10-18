using System;

namespace Geometry
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            //Console.WriteLine(area(fd));
            Console.WriteLine("Ok");
        }
    }
}
