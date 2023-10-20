namespace Generics
{
    class ReadonlyStorage<T>
        where T : IComparable<T>
    {
        public bool IsGreater(T x)
        {
            return Data.CompareTo(x) > 0;
        }
        
        public T Data { get; init; }
        public ReadonlyStorage(T data)
        {
            Data = data;
        }
    }

    internal class Program
    {
        static bool IsGreater<T>(T a, T b)
                where T : IComparable<T>
        {
            return a.CompareTo(b) > 0;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T x = default(T);
            T c = a; 
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsGreater(3, 2));
            Console.WriteLine(IsGreater(3.2, 2.5));
            Console.WriteLine(IsGreater<string>("abc", "cde"));

            ReadonlyStorage<int> r1 = new ReadonlyStorage<int>(5);
            ReadonlyStorage<double> r2 = new ReadonlyStorage<double>(5.2);
            ReadonlyStorage<string> r3 = new ReadonlyStorage<string>("Abc");
            //ReadonlyStorage<Program> r4 = new ReadonlyStorage<Program>(new Program());

            Console.WriteLine(r1.Data * 2);
            Console.WriteLine(r2.Data );
            Console.WriteLine(r2.IsGreater(0d));
            Console.WriteLine(r3.Data);
        }
    }
}
