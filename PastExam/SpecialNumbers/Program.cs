using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int number = 1111; number < 10000; number++)
            {

                bool isSpecial = true;
                int currNumber = number;

                while (currNumber != 0)
                {
                    int lastDigit = currNumber % 10;
                    currNumber = currNumber / 10;
                    if (lastDigit == 0 || n % lastDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write("{0} ", number);
                }
                
            }

        }
    }
}
