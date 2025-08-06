﻿using SimpleCalculator.Interfaces;

namespace SimpleCalculator.Services
{
    public class Calculator : ICalculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }

        public double Power(double a, double b) => Math.Pow(a, b);

    }
}
