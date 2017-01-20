using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double magnoliasCount = double.Parse(Console.ReadLine());
            double zumbulsCount = double.Parse(Console.ReadLine());
            double rosesCount = double.Parse(Console.ReadLine());
            double cactusesCount = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());


            double magnoliaPrice = 3.25;
            double zumbulPrice = 4.0;
            double rosePrice = 3.5;
            double cactusPrice = 8.0;
            double totalFunds = ((magnoliaPrice * magnoliasCount) + (zumbulPrice * zumbulsCount) + (rosePrice * rosesCount) + (cactusPrice * cactusesCount));
            double finalFunds = (totalFunds - (totalFunds * 0.05));

            double difference = giftPrice - finalFunds;
            double moneyneeded = Math.Abs(difference);

            if (difference <= 0)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(moneyneeded));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(moneyneeded));
            }
        }
    }
}
