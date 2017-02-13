using System;


namespace SumArrayElements
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                numbers[i] = currNumber;
            }

            int sumOfArray = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfArray = numbers[i] + sumOfArray;
            }

            Console.WriteLine(sumOfArray);
        }
    }
}
