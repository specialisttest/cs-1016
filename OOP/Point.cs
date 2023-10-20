using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Point : Shape, IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }  

        public Point(int x, int y, string color = DEFAULT_COLOR)
            : base(color)
        {
            this.X = x;
            this.Y = y;
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

        public double Distance
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        public static Point operator +(Point p1, Point p2)
        {
            // p1.X = 0; //bad
            return new Point(p1.X+p2.X, p1.Y+p2.Y);
        }

        public static Point operator +(Point p1, int k)
        {
            return new Point(p1.X + k, p1.Y + k);
        }
        public static Point operator +(int k, Point p1)
        {
            return p1 + k;
        }

        public override int GetHashCode()
        {
            return (X,Y).GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point p)
                return this.X == p.X && this.Y == p.Y;
            else
                return base.Equals(obj);
        }

        public int CompareTo(Point p)
        {
            if (this.Distance > p.Distance) return 1;
            if (this.Distance < p.Distance) return -1;
            return 0;
        }

        public static bool operator ==(Point p1, Point p2)
        { 
            return object.Equals(p1, p2);
        }
        public static bool operator !=(Point p1, Point p2)
        { 
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        { 
            return p1.CompareTo(p2) > 0;    
        }
        public static bool operator <(Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static explicit operator double(Point p)
        {
            return p.Distance;
        }

        public int this[int index]
        {
            get 
            {
                switch (index) { 
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
                    case 1: Y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }

        }
        public int this[string index]
        {
            get
            {
                switch (char.ToLower(index[0]))
                {
                    case 'x': return X;
                    case 'y': return Y;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (char.ToLower(index[0]))
                {
                    case 'x': X = value; break;
                    case 'y': Y = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }

        }
    }
}
