//#define _DEBUG
//#define _RUS


using System;
using Abc;
using SCS = System.Collections.Specialized;

namespace Another.My
{
    class Test { 
    
    }
}

namespace Abc {
    class Test2 { 
    
    }
}

namespace App {

    class Test { 
    
    }
}

namespace MyNm.Program
{
    namespace Abc {
        //MyNm.Program.Abc.Test4

        class Test4 { }
    }
    
    
    /// <summary>
    /// Main program class
    /// </summary>
    class App
    {
        MyNm.Program.Abc.Test4 t4;
        Another.My.Test t;
        Test2 test;

        global::App.Test y;
        
        public int UserCounter; // pascal notation

        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args">command line parameters</param>
        public static void Main(string[] args)
        {
            //object
            //System.Object
            //System.Int32
            //String




            #region local vars

            int a = 123;
            double d = 1.5;
            double e = 2e7;
            decimal dc = 1.5m;

            uint k1 = int.MaxValue;
            int k2 = 5;

            string s = null;
            bool t = true;
            char c = 'a';
            s = "Привет\n";
            s = "  \"dfjk\\lgjdf\"    ";
            string path = @"c:\cs-1016\hello";

            string name = "Sergey";
            // Hello, Sergey!
            //string hello = "Hello, " + name + "!";
            string hello = $"Hello, {name}!"; // Hello, Sergey!

            string abc = null;
            short k = 5;
            int ki = k; // implicit conversion
            k = (short)ki; // explicit conversion

            long k3;

            k3 = k1 + k2;
            var app = new App();

            unsafe
            {
                int* p = &a;
            }

            #endregion

            Console.WriteLine(a);
            /*

            // строчный комментарий
            int userCounter; // camel notation
            */

            SCS.NameValueCollection nvc = 
                new SCS.NameValueCollection();

            Console.WriteLine("Hello, World!");

#if _RUS
        Console.WriteLine("Привет ужасный мир!");
#endif

#if _DEBUG
        Console.WriteLine("write message to log");
#endif

        }
    }



}
