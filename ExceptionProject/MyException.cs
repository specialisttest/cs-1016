using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    public class MyException : ArgumentOutOfRangeException
    {
        public int InvalidData { get; init; }
        public MyException(string message, int invalidData) 
            :base(message)
        { 
            this.InvalidData = invalidData;
        }
        public MyException(Exception innerException,string message, int invalidData)
            : base(message, innerException)
        {
            
            this.InvalidData = invalidData;
        }

    }
}
