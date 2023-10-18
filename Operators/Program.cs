namespace Operators
{
    internal class Program
    {

        static string num(int a) {
            switch (a)
            {
                case -1:
                case 1:return "один";
                case 2:return "два";
                case 3:return "три";
                default:return "много";
            }
        }
        static string num2(int a) => a switch
        {
            1 or -1 => "один",
            2 => "два",
            3 => "три",
            _ => "много"
        };
        

        static void Main(string[] args)
        {
            int n = -5;
            if (n > 0)
            {
                Console.WriteLine("n больше нуля");
                Console.WriteLine("n > 0");
            }
            else 
                if (n > -100)
                    Console.WriteLine("n > -100");
                else
                    Console.WriteLine("n НЕ больше нуля");

            int a = 0;
            /*string s;
            if (a == 0)
                s = "ноль";
            else
                s = "не ноль";*/

            string s = (a == 0) ? "ноль" : "не ноль";
            Console.WriteLine(s);

            string name = null;  //"Sergey";

            //if (name == null) name = "Sergey";
            name ??= "Sergey";

            /*if (name != null)
                Console.WriteLine(name.ToUpper());
            else
                Console.WriteLine( "<пусто имя>");*/

            //Console.WriteLine( name != null ? name.ToUpper() : "<пусто имя>" );
            //Console.WriteLine(name != null ? name : "<пусто имя>");
            Console.WriteLine( (name ?? "<пусто имя>").ToUpper() );

            a = 20;
            switch (a)
            {
                case -1:
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два"); 
                    break;
                case 3:
                    Console.WriteLine("три");
                    break; 
                default: 
                    Console.WriteLine("много");
                    break;
            }



            object o = "Sergey";

            switch(o)
            {
                case int i when i >=0 && i <= 100: 
                    Console.WriteLine("int o in [0, 100]");break;
                case int : Console.WriteLine("int o"); break;
                case double : Console.WriteLine("double o"); break;
                default : Console.WriteLine("????");break;
            }


        }
    }
}
