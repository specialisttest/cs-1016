using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IScaleable
    {
        static int k = 5;
        public static void Abc() { }
        
        
        
        
        // public abstract
        void Scale(double factor)
        {
            Console.WriteLine("default IScaleable.Scale");
        }
    }

    public interface IScaleable3D
    {
        // public abstract
        void Scale(double factor)
        {
            Console.WriteLine("default IScaleable3D.Scale");
        }
        void Scale3D(double factorX, double factorY, double factorZ);
    }

}
