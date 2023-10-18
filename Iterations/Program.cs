namespace Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i = i + 1;
            // i += 1;
            // i++;
            // ++i;
            // i = 10;
            // x = i++

            for (int i=1; i <= 10; i++)
            {
                if (i == 8) break;
                if (i == 4) continue;
                Console.WriteLine(i);
            }

            // 1 2 3 .. 10
            // 2 4 6 .. 20
            // ...
            // 10 20 30 .. 100

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5) goto metka;
                    Console.Write("{0,-5}", i * j);
                }
                Console.WriteLine();
            }
        metka:
            Console.WriteLine();

            int a = 2000;
            //for(; a < 1000; )
            while (a < 1000)
            {
                Console.WriteLine(a);
                a *= 2; // a = a * 2;
            }

            a = 2;
            do
            {
                Console.WriteLine(a);
                //a *= 2;
            } while ( (a *= 2) < 1000);

            /*
             * Вывести числа Фибоначчи < 1000
             * 0 1 1 2 3 5 8 13 21 ...
             * 
             */
            int k1 = 0, k2 = 1, k3;
            Console.WriteLine($"{k1}\n{k2}");
            while ( (k3 = k1+ k2) < 1000 )
            {
                Console.WriteLine(k3);
                k1 = k2;
                k2 = k3;
            }

            IList<string> names = new List<string>(){ "Елена", "Алина", "Дарья" };
            names.Add("Глафира");
            
            //for(int i=0; i < nums.Length; i++)
            //    Console.WriteLine(nums[i]);

            /*IEnumerator<string> en = names.GetEnumerator();
            while (en.MoveNext()) 
            {
                Console.WriteLine(en.Current);
            }*/


            foreach(var name in names)
                Console.WriteLine(name);


        }
    }
}
