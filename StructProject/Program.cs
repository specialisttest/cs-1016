namespace StructProject
{
    struct Money
    {
        public decimal Summa;
        public string Currency;

        public Money(decimal Summa, string Currency) 
        { 
            this.Summa = Summa; 
            this.Currency = Currency;   
        }

        public override string ToString() => $"{Summa}{Currency}";
    }

    struct Point {
        public byte x, y;
    }


    internal class Program
    {
        static void Draw(in Point p)
        {
            //p.x++;
            Console.WriteLine($"{p.x}, {p.y}");
        }
        static void Main(string[] args)
        {
            Point p1 = new Point { x = 10, y = 20 };
            Draw(ref p1);
            
            Money m1 = new Money(100, "RUB");
            //m1.Summa = 100;
            //m1.Currency = "RUB";

            Money m2 = m1;
            m2.Currency = "USD";

            Console.WriteLine($"{m1.Summa}{m1.Currency}");
            Console.WriteLine(m2);

            Console.WriteLine(sizeof(byte));
        }
    }
}
