using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', S));
            for (int T = 0; T < S - 2; T++)
            {
                Console.Write("*");
                for (int R = 0; R < S - 2; R++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', S));
        }
    }
}
