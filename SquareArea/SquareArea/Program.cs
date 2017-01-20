using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            var x = int.Parse(Console.ReadLine());
            var area = x * x;
            Console.Write("Area = ");
            Console.WriteLine(area);
          
        }
    }
}
