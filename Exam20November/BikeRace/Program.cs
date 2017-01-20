using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {

            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string terrain = Console.ReadLine();

            double juniorSingleTax = 0;
            double seniorSingleTax = 0;

            if (terrain == "trail")
            {
                juniorSingleTax = 5.50;
                seniorSingleTax = 7.0;
            }
            else if (terrain == "cross-country")
            {
                juniorSingleTax = 8.0;
                seniorSingleTax = 9.50;

                if (juniors + seniors >= 50)
                {
                    juniorSingleTax = (juniorSingleTax - (juniorSingleTax * 0.25));
                    seniorSingleTax = (seniorSingleTax - (seniorSingleTax * 0.25));
                }

            }
            else if (terrain == "downhill")
            {
                juniorSingleTax = 12.25;
                seniorSingleTax = 13.75;
            }
            else
            {
                juniorSingleTax = 20.0;
                seniorSingleTax = 21.50;
            }

            double juniorsTotalFunds = juniors * juniorSingleTax;
            double seniorsTotalFunds = seniors * seniorSingleTax;
            double totalFunds = juniorsTotalFunds + seniorsTotalFunds;
            double expenses = totalFunds / 20;
            double finalFunds = totalFunds - expenses;

            Console.WriteLine("{0:f2}", finalFunds);

        }
    }
}
