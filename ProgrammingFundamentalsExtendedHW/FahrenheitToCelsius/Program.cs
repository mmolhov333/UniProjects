using System;


namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main()
        {
            Console.Write("Temperature in Fahrenheit: ");
            var degrees = double.Parse(Console.ReadLine());
            degrees = FheitToCsiusConv(degrees);
            Console.WriteLine($"Temperature in Celsius: {degrees}");   
        }

        static double FheitToCsiusConv(double input)
        {
            var CelsiusDegrees = (input - 32) * 5 / 9;
            return CelsiusDegrees;
        }
    }
}
