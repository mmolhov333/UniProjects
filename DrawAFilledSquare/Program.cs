using System;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main()
        {
            PrintTheSquare();
        }

        static void PrintTheSquare()
        {
            int n = int.Parse(Console.ReadLine());

            PrintBorder(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }
            PrintBorder(n);
        }

        static void PrintBody(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine('-');
        }

        static void PrintBorder(int n)
        {
            var border = new string('-', n * 2);
            Console.WriteLine(border);
        }
    }
}
