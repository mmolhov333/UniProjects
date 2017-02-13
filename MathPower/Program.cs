using System;

namespace MathPower
{
    class Program
    {
        static void Main()
        {
            var numberInput = double.Parse(Console.ReadLine());
            var exponentInput = double.Parse(Console.ReadLine());

            var result = Exponentiation(numberInput, exponentInput);

            Console.WriteLine(result);
        }

        static double Exponentiation(double number, double exponent)
        {
            double exponentedNumber = Math.Pow(number, exponent);
            return exponentedNumber;
        }
    }
}
