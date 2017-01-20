using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double dailyPrice = 0.0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    dailyPrice = 2.50;
                }
                else if (fruit == "apple")
                {
                    dailyPrice = 1.20;
                }
                else if (fruit == "orange")
                {
                    dailyPrice = 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    dailyPrice = 1.45;
                }
                else if (fruit == "kiwi")
                {
                    dailyPrice = 2.70;
                }
                else if (fruit == "pineapple")
                {
                    dailyPrice = 5.50;
                }
                else if (fruit == "grapes")
                {
                    dailyPrice = 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    dailyPrice = 2.70;
                }
                else if (fruit == "apple")
                {
                    dailyPrice = 1.25;
                }
                else if (fruit == "orange")
                {
                    dailyPrice = 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    dailyPrice = 1.60;
                }
                else if (fruit == "kiwi")
                {
                    dailyPrice = 3.00;
                }
                else if (fruit == "pineapple")
                {
                    dailyPrice = 5.60;
                }
                else if (fruit == "grapes")
                {
                    dailyPrice = 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            Console.WriteLine(quantity * dailyPrice);
        }
    }
}
