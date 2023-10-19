using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int Add() => X + Y;
        public int Minus() => X + Y;
    }
}
