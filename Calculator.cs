using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Mul(double x, double y)
        {
            return x * y;
        }

        public double Div(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return x / y;
        }

        public double Mod(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Modulus by zero is not allowed.");
            }
            return x % y;
        }
    }
}
