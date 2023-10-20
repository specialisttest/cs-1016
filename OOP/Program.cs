using System.Drawing;
using System.Text;
using static System.Math;

namespace OOP
{
    public partial class Person
    {
        public required string EMail;

        partial void Validate()
        {
            Console.WriteLine("Validate");
        }

    }

    static class StringExtension
    { 
        public static string Capitalize(this string s) 
        {
            string[] words = s.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length > 0)
                    stringBuilder.Append(char.ToUpper(word[0])).
                        Append(word.Substring(1).ToLower()).Append(' ');
            }
            return stringBuilder.ToString();
        }

        public static int Pow(this int x, int s) 
        {
            int r = 1;
            for (int i=1; i <=s; i++)
                r *= x;
            return r;
        }
    }


    internal class Program
    {
        static void DrawScene(IEnumerable<Shape> scene)
        {
            /* VMT
             * Class    Method  Address
             * Point    Draw        XXX
             * Circle   Draw        YYY
             * Line     Draw        ZZZ
             * 
             */
            
            foreach (Shape s in scene)
                s.Draw();
        }
        static void ScaleScene(IEnumerable<Shape> scene, double factor)
        {
            foreach (Shape s in scene)
                if (s is IScaleable sc)
                    sc.Scale(factor);

                /*if (s is IScaleable)
                {
                    IScaleable sc = (IScaleable)sc;
                    sc.Scale(factor);
                }*/
                /*IScaleable sc = s as IScaleable;
                if (sc != null)
                    sc.Scale(factor); */
                //(s as IScaleable)?.Scale(factor);


        }

        static IEnumerable<string> GetNames()
        {
            yield return "Sergey";
            yield return "Anna";
            yield return "Elena";
        }

        static IEnumerable<Shape> CreateScene()
        {
            yield return new Circle(10, 20, 100, "green");
            yield return new Point(10, 20, "pink");
            yield return new Line(1, 1, 10, 10, "red");
        }

        static void Main(string[] args)
        {
            foreach(var s in GetNames())
                Console.WriteLine(s);
            
            // double y = log(sin(x*PI))
            double x = 1;
            double y = Log(Sin(x * PI));
            string hello = "hello sergey"; // Hello Sergey
            //hello.Capitalize()
            //string result = StringExtension.Capitalize(hello);
            string result = hello.Capitalize();
            Console.WriteLine(result);

            int k = 7;
            int k3 = k.Pow(3);
            //int k3 = StringExtension.Pow(k, 3);

            Console.WriteLine(k3);

            {
                Person.PrintTotal();

                Person p1 = new Person("Анна", 18) { EMail = "anna@anna.ru" };

                //p1.Name = "Анна";
                //p1.Age  = 18;

                Person p2 = new Person("Елена", 27) { EMail = "helen@elena.ru"};
                //p2.Name = "Елена";
                //p2.Age = 27; 

                Person px = new Person() { EMail = "helen@elena.ru" }; ;

                p1.Show(); // this == p1
                p2.Show(); // this == p2
                px.Show();

                p1 = p2 = px = null;
                Person.PrintTotal();

            }
            Circle c1 = new Circle(10, 20, 100, "green");
            //c1.Radius = 10; // set
            Console.WriteLine(c1.Radius); // get
            //c1.setRadius(-10);
            //c1.Draw();

            Shape s1 = c1;   //implicit conv
                             //s1.Draw(); // Circle.Draw если virtaul Draw!!!!


            //s1 = new Shape();

            /*if (s1 is Circle) 
            {
                Circle c2 = (Circle)s1;  // explicit conv
                c2.Draw();
            }*/
            /*if (s1 is Circle c2)
            {
                c2.Draw();
            }*/


            //Circle c2 = s1 as Circle;  //
            //c2?.Draw();

            Point po1 = new Point(10, 20, "pink");
            Line l1 = new Line(1, 1, 10, 10, "red");

            //Shape[] scene = { c1, po1, l1 };
            var scene = CreateScene();
            DrawScene(scene);
            //ScaleScene(scene, 2);
            c1.Scale(2);
            IScaleable sc = c1;
            sc.Scale(2);
            IScaleable3D sc3d = c1;
            sc3d.Scale(2);

            DrawScene(scene);

            object o = c1;
            o = po1;
            o = l1;
            o = "String";

            o = 4; // boxong
            /*if (o is int)
            {
                int ki = (int)o; // unboxing
            }*/

            if (o is int ki) // unboxing
            {
                Console.WriteLine(ki);
            }


            //var point = new { X = 10, Y = 20, Color = "Red" };
            
            //Console.WriteLine(point);
            //Console.WriteLine(point.GetType().FullName);

            Date now = new Date(2023, 2, 29);
            Console.WriteLine(now.Validate());
            now.Print();
            {
                Point p1 = new Point(10, 20);
                Point p2 = new Point(30, 10);
                Point p3 = p1 + p2;
                //Point.Add(p1, p2);
                //p1.Add(p2);
                //

                //Point p4 = 5 +p3;
                p3 += 5;

                p1.Draw();
                p2.Draw();
                p3.Draw();
                //p4.Draw();

                double d = (double)p1;
                Circle c = new Circle(10, 20, 30);
                Point point = (Point)c;

                Point pp1 = new Point(1, 1);
                Point pp2 = new Point(1, 1);
                Console.WriteLine(pp1.Equals(pp2));
                Console.WriteLine(pp1 == pp2);
                Console.WriteLine(p1[0]);
                Console.WriteLine(p1[1]);
                Console.WriteLine(p1["x"]);
                Console.WriteLine(p1["y"]);
            }
            {
                Box box = new Box(10, 20);
                Box box2 = box with { Height = 10 };
            }
        }
    }
}
