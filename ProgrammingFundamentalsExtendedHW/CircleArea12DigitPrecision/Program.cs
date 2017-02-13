using System;

namespace CircleArea12DigitPrecision
{
    class Program
    {
        static void Main()
        {

            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * 2;
            Console.WriteLine($"{area:f12}");

        }
    }
}
