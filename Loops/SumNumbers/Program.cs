using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int sum = 0;
            
            for (int n = 0; n < numberCount; n++)
            {
                int add = int.Parse(Console.ReadLine());
                sum = sum + add;
            }
            Console.WriteLine(sum);
        }
    }
}
