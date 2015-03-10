using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {
        }

        public int Add(int a, int b)
        {
            return checked(a + b);
        }

        public int Substract(int a, int b)
        {
            return checked(a - b);
        }

        public int Multiply(int a, int b)
        {
            return checked(a * b);
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return checked((double)a / b);
        }
    }
}
