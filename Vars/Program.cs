using System.Numerics;

namespace Vars
{
    enum FileMode : byte { Read = 1, Write = 100, ReadWrite = 200 }

    internal class Program
    {
        static int a;

        static bool B() {
            Console.WriteLine("B()");
            return false;
        }

        static void Main(string[] args)
        {
            {
                int b = 34;

                int counter = 123;

                counter = b + 2;

                string s = "Sergey";

                Console.WriteLine(s.ToUpper());
                Console.WriteLine(s[0]);

                Console.WriteLine(counter);
            }
            {
                bool a = false;
                bool b = false;

                bool c = a && !B();
                //&&
                //&

                Console.WriteLine(c);

            }
            { 
                string s = null;
                int k = 0;
                int? kq = null;

                //if (kq == null)
                //    kq = 6;
                kq ??= 6;

                /*if (kq == null)
                    number = 0;
                else
                    number = kq.Value;*/
                int number = kq ?? 0; 



                //if (kq != null)
                if (kq.HasValue)
                {
                    Console.Write(kq);
                    int k1 = kq.Value;
                }
                    
                else
                    Console.Write("No value");

                BigInteger r = BigInteger.Pow( new BigInteger(int.MaxValue), 230);
                Console.WriteLine(r);

            }

            { 
                FileMode fm = FileMode.Write;
                Console.WriteLine( sizeof (FileMode) );
                //Console.WriteLine(sizeof(int));
                int k = (int)fm;
                Console.WriteLine(k);
            }

        }
    }
}
