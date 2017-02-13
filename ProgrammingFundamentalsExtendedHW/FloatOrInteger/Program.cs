using System;

namespace FloatOrInteger
{
    class Program
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine());

            if (input / input == 0)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(Math.Round(input));
            }
        }
    }
}
