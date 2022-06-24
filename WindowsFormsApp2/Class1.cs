using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Class1
    {
        public double Addition(double a, double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        public double DivisionOne(double a)
        {
            return (1 / a);
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double FuncPow(double a, double b = 2)
        {
            return Math.Pow(a, b);
        }

        public double FuncSqrt(double a)
        {
            return Math.Sqrt(a);
        }

        public double FuncSqrtn(double a, double b)
        {
            return Math.Pow(a, (1 / b));
        }

        public double FuncTan(double a)
        {
            return Math.Tan(a);
        }

        public double FuncAtan(double a)
        {
            return Math.Atan(a);
        }

        public double FuncSin(double a)
        {
            return Math.Sin(a);
        }
        public double FuncLog(double a)
        {
            return Math.Log(a);
        }
        public double FuncCos(double a)
        {
            return Math.Cos(a);
        }

        public double SredZnach(double a, double b)
        {
            return (a + b) / 2;
        }

    }
}
