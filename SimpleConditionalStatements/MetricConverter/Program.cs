using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var meter = 1;
            var meterTomm = 1000;
            var meterTocm = 100;
            var meterTomi = 0.000621371192;
            var meterToin = 39.3700787;
            var meterTokm = 0.001;
            var meterToft = 3.2808399;
            var meterToyd = 1.0936133;
            var number = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();
            if (from == "mm")
            {
                number = number / meterTomm;
            }
            else if (from == "cm")
            {
                number = number / meterTocm;
            }
            else if (from == "mi")
            {
                number = number / meterTomi;
            }
            else if (from == "in")
            {
                number = number / meterToin;
            }
            else if (from == "km")
            {
                number = number / meterTokm;
            }
            else if (from == "ft")
            {
                number = number / meterToft;
            }
            else if (from == "yd")
            {
                number = number / meterToyd;
            }

            /////////////

            if (to == "mm")
            {
                number = number * meterTomm;
            }
            else if (to == "cm")
            {
                number = number * meterTocm;
            }
            else if (to == "mi")
            {
                number = number * meterTomi;
            }
            else if (to == "in")
            {
                number = number * meterToin;
            }
            else if (to == "km")
            {
                number = number * meterTokm;
            }
            else if (to == "ft")
            {
                number = number * meterToft;
            }
            else if (to == "yd")
            {
                number = number * meterToyd;
            }

            Console.WriteLine("{0} {1}", number, to);
        }
    }
}
