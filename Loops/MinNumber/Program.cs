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
            int Min = 100000000;

            for (int n = 0; n < numbersCount; n++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < Min)
                {
                    Min = num;
                }
            }

            Console.WriteLine(Min);
        }
    }
}
