using System.Diagnostics;

namespace ExceptionProject
{
    internal class Program
    {
        static void Divide(string s1, string s2)
        {
            try
            {
                checked
                { 
                
                }
                int n1 = int.Parse(s1);
                int n2 = int.Parse(s2);

                if (n1 < 0 || n1 > 100)
                    //throw new ArgumentOutOfRangeException("n1 out of [0..100]");
                    throw new MyException("n1 out of [0..100]", n1);

                int n = checked( n1 / n2 );

                Console.WriteLine(n);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Не число");
            }
            catch (MyException e)
            {
                Console.WriteLine($"{e.Message} Invalid data: {e.InvalidData}");
                //throw; // throw e;
                throw new ArgumentException(e.Message, e);
            }

            Console.WriteLine("продолжение Divide()");
        }


        static void Main(string[] args)
        {
            try
            {
                Divide("123", "4");
                return;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                //Debug.WriteLine(e);
                //Trace.WriteLine(e);
            }
            finally 
            { 
                Console.WriteLine("finally");
            }
            Console.WriteLine("продолжение Main()");
        }
    }
}
