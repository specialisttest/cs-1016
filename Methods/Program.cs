using System.Xml.Linq;

using DoublePair = (double cos, double sin);

namespace Methods
{
    internal class Program
    {
        // overloading
        // best practice
        public static void SayHello()
        {
            Console.WriteLine("Привет!");
        }
        public static void SayHello(string name = "Незнакомец", int age = 18)
        {
            Console.WriteLine($"Привет, {name} - {age}!");
        }

        static void Test1(int a)
        {
            a++;
            Console.WriteLine($"Test1 a = {a}"); // 11
        }
        static void Test2(ref int a)
        {
            a++;
            Console.WriteLine($"Test2 a = {a}"); // 11
        }
        static void Test3(out int a)
        {
            a = 12;
            //a++;
            //a = a + 1;
            Console.WriteLine($"Test3 a = {a}"); // 12
        }
        static void Test4(in int a)
        {
            Console.WriteLine($"Test4 a = {a}"); // 12
            return;
        }


        static double Average(int a, int b) => (a + b) / 2d;
        
        static double Average(int a, int b, int c)
        {
            double avg = (a + b + c) / 3d;
            return avg;
        }

        static double Average(params int[] m)
        {
            long sum = 0L;
            foreach (int k in m)
                sum += k;

            return (double)sum / m.Length;
        }


        static (double cos ,double sin) SinCos(double a, double b) 
        {
            double getH()
            {
                return Math.Sqrt(a * a + b * b);
            }

            double h = getH();
            double cos = a / h;
            double sin = b / h;
            return (cos, sin);
        }


        static void Main(string[] args)
        {
            { 
                int a = 10;
                Test1(a); // by value
                Console.WriteLine($"Main1 a = {a}"); // 10
            }
            {
                int b = 10;
                Test2(ref b); // by ref
                Console.WriteLine($"Main2 b = {b}"); // 11
            }
            {
                int b;
                Test3(out b); // by ref
                Console.WriteLine($"Main3 b = {b}"); // 12
            }

            //Program app = new Program();
            //app.SayMethod();
            Program.SayHello("Елена");
            SayHello("Анфиса", 27);
            SayHello(age:27, name:"Анфиса");
            SayHello();
            SayHello(age:40);

            double x = Average(10, 11);
            Console.WriteLine(x);
            Console.WriteLine(Average(10, 11));
            //Console.WriteLine(Average( new int[] { 10, 11, 12, 13, 14 } ));
            Console.WriteLine(Average( 10, 11, 12, 13, 14, 15, 16 ));

            DoublePair r = SinCos(1, 1);
            Console.WriteLine($"cos = {r.cos}\nsin = {r.sin}");
                


        }
    }
}
