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

        public double add(double addend)
        {
            return Accumulator = Accumulator + addend;
        }

        public double subtract(double a, double b)
        {
            return Accumulator = a - b;
        }

        public double subtract(double subtractor)
        {
            return Accumulator = Accumulator - subtractor;
        }


        public double multiply(double a, double b)
        {
            return Accumulator = a * b;
        }

        public double multiply(double multiplier)
        {
            return Accumulator =  Accumulator * multiplier;
        }

        public double power(double x, double exp)
        {
            return Accumulator = Math.Pow(x,exp);
        }

        public double power(double exponent)
        {
            return Accumulator = Math.Pow(Accumulator, exponent);
        }

        public double divide(double a, double b)
        {
            if (b != 0)
            {
                return Accumulator = a / b;
            }
            else
            {
                throw new InvalidOperationException("Can't divide by 0");
            }

        }


        public double divide(double divisor)
        {
            return Accumulator =  Accumulator / divisor;
        }

        public double Accumulator { get; private set; }


        public void clear()
        {
            Accumulator = 0;
        }
    }
}
