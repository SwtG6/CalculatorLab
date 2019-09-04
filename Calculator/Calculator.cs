using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        //private double _result = 0;
        
        public double add(double a, double b)
        {
           
            return Accumulator = a + b;
        }

        public double add(double a)
        {
            return Accumulator = a + Accumulator;
        }

        public double subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double subtract(double a)
        {
            return Accumulator = a - Accumulator;
        }


        public double multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double multiply(double a)
        {
            return Accumulator = a * Accumulator;
        }

        public double power(double x, double exp)
        {
            return Accumulator = Math.Pow(x,exp);
        }

        public double power(double x)
        {
            return Accumulator = Math.Pow(x, Accumulator);
        }

        public double divide(double a, double b)
        {
            return Accumulator = a / b;
        }

        public double divide(double a)
        {
            return Accumulator = a / Accumulator;
        }

        public double Accumulator { get; private set; }


        public void clear()
        {
            Accumulator = 0;
        }
    }
}
