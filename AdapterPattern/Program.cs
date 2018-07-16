using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Adapter Pattern Demo***\n");
            CalculatorAdapter cal = new CalculatorAdapter();
            Triangle tr = new Triangle(20,10);
            Console.WriteLine("Area of Triangle is " + cal.GetArea(tr) + "sq.unit");
            Console.ReadLine();
        }
    }

    internal class Triangle
    {
        public readonly int BaseT;
        public readonly int Height;

        public Triangle(int b, int h)
        {
            BaseT = b;
            Height = h;
        }
    }

    internal class CalculatorAdapter
    {
        public object GetArea(Triangle tr)
        {
            Calculator cal = new Calculator();
            Rect rect = new Rect
            {
                Length = tr.BaseT,
                Width = tr.Height * 0.5
            };
            return cal.GetArea(rect);
        }
    }

    internal class Rect
    {
        public double Length;
        public double Width;
    }

    internal class Calculator
    {
        public object GetArea(Rect rect)
        {
            return rect.Length * rect.Width;
        }
    }
}