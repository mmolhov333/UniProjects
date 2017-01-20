using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int Max = -100000000;

            for (int n = 0; n < numbersCount; n++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > Max)
                {
                    Max = num;
                }
            }

            Console.WriteLine(Max);
        }
    }
}
