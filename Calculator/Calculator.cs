using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        public double add(double a, double b)
        {
            return a + b;
        }

        // public void GetAdd(double x)
        // 
        //     x = 
        // }

        public double subtract(double a, double b)
        {
            return a - b;
        }

        public double multiply(double a, double b)
        {
            return a * b;
        }

        public double power(double x, double exp)
        {
            return Math.Pow(x,exp);
        }

        public double divide(double a, double b)
        {
            return a / b;
        }

        public double Accumulator { get; private set; }

        public void clear()
        {
            Accumulator = 0;
        }
    }
}
