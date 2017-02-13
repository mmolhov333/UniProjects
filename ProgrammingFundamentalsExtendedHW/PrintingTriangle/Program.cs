using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        static void PrintTriangle(int n)
        {
            for (int i = 1; i < n; i++)
            {
                PrintLine(i);
            }
            for (int i = n; i >= 1; i--)
            {
                PrintLine(i);
            }        
        }

        static void PrintLine(int size)
        {
            for (int i = 1;i <= size; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
