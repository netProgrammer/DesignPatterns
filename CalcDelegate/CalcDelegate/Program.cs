using System;
using System.Collections.Generic;

namespace CalcDelegate
{
    internal class Program
    {
        private static void Main()
        {
            var calc = new Calculator();
            calc.DefineOperation("mod", (x, y) => x % y);
            var mod = calc.PerformOperation("mod", 3.0, 2.0);
            Console.WriteLine(mod);
            Console.ReadLine();
        }
    }

    internal class Calculator
    {
        private Dictionary<string, Func<double, double, double>> _operations;

        public Calculator()
        {
            _operations = new Dictionary<string, Func<double, double, double>>
            {
                {"+", (a, b) => a + b},
                {"-", (a, b) => a - b},
                {"*", (a, b) => a * b},
                {"/", (a, b) => a / b},
            };
        }

        public void DefineOperation(string opr, Func<double, double, double> func)
        {
            if (!_operations.ContainsKey(opr))
            {
                _operations.Add(opr, func);
            }
        }

        public double PerformOperation(string opr, double a, double b)
        {
            if (!_operations.ContainsKey(opr))
            {
                throw new ArgumentNullException(opr);
            }
            return _operations[opr](a, b);
        }
    }
}