using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var F = Math.Round(C * 1.8 + 32, 2);
            Console.WriteLine(F);
        }
    }
}
