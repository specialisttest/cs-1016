using System.Drawing;
using System.Text;
using static System.Math;

namespace OOP
{
    public partial class Person
    {
        public string EMail;

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
        static void Main(string[] args)
        {
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


            Person.PrintTotal();
            
            Person p1 = new Person("Анна", 18) { EMail="anna@anna.ru" };
            
            //p1.Name = "Анна";
            //p1.Age  = 18;

            Person p2 = new Person("Елена", 27);
            //p2.Name = "Елена";
            //p2.Age = 27; 
            
            Person px = new Person();

            p1.Show(); // this == p1
            p2.Show(); // this == p2
            px.Show();

            p1 = p2 = px = null;

            Circle c1 = new Circle(10, 20, 100, "GREEN");  
            //c1.Radius = 10; // set
            Console.WriteLine(c1.Radius); // get
            //c1.setRadius(-10);
            c1.Draw();

            Shape s1 = c1;   //implicit conv
            s1.Draw(); // Circle.Draw если virtaul Draw!!!!
            

            //s1 = new Shape();

            /*if (s1 is Circle) 
            {
                Circle c2 = (Circle)s1;  // explicit conv
                c2.Draw();
            }*/
            if (s1 is Circle c2)
            {
                c2.Draw();
            }
            
            
            //Circle c2 = s1 as Circle;  //
            //c2?.Draw();





            Person.PrintTotal();

            //var point = new { X = 10, Y = 20, Color = "Red" };
            
            //Console.WriteLine(point);
            //Console.WriteLine(point.GetType().FullName);

            Date now = new Date(2023, 2, 29);
            Console.WriteLine(now.Validate());
            now.Print();
        }
    }
}
