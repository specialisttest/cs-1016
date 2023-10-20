using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    [Author("Sergey")]
    public class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        [Label("Сложение чисел")]
        public int Add() => X + Y;
        [Label("Вычитание чисел")]
        public int Minus() => X + Y;
    }
}
