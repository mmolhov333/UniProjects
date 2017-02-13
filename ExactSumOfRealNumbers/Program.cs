using System;

namespace Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberscount = int.Parse(Console.ReadLine());

            decimal totalproduct = 0;

            for (int n = 0; n < numberscount; n++)
            {
                totalproduct += decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(totalproduct);
        }
    }
}
