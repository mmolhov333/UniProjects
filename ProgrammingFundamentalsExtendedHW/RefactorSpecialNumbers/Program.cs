using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)          
            {                
                var currNumber = i;
                var sum = 0;

                while (currNumber > 0)
                {
                    sum += currNumber % 10;

                    currNumber = currNumber / 10;
                }

                var result = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {result}");
            }
        }
    }
}
