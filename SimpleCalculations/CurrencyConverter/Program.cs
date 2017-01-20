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
            var bgn = 1;
            var bgnToUsd = 1.79549;
            var bgnToEur = 1.95583;
            var bgnToGbp = 2.53405;
            var number = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();
            if (from == "USD")
            {
                number = number * bgnToUsd;
            }
            else if (from == "EUR")
            {
                number = number * bgnToEur;
            }
            else if (from == "GBP")
            {
                number = number * bgnToGbp;
            }
            
            /////////////

            if (to == "USD")
            {
                number = number / bgnToUsd;
            }
            else if (to == "EUR")
            {
                number = number / bgnToEur;
            }
            else if (to == "GBP")
            {
                number = number / bgnToGbp;
            }

            Console.WriteLine("{0:f2} {1}",number,to);
        }
    }
}
