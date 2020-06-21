using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MathsOperations
{
    public static class Calculator
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiply (int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            return a / b;
        }

        public static int Square(int a)
        {
            var res  = a* a;
         //   return res;
        }
    }
}
