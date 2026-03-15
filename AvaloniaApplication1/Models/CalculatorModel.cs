using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplication1.Models
{
    internal class CalculatorModel
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на 0 невозможно");
            }

            return a / b;
        }
    }
}
