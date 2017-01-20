using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal ProductPrice = 0M;
            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    ProductPrice = 0.50M;
                }
                else if (product == "water")
                {
                    ProductPrice = 0.80M;
                }
                else if (product == "beer")
                {
                    ProductPrice = 1.20M;
                }
                else if (product == "sweets")
                {
                    ProductPrice = 1.45M;
                }
                else
                {
                    ProductPrice = 1.60M;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    ProductPrice = 0.40M;
                }
                else if (product == "water")
                {
                    ProductPrice = 0.70M;
                }
                else if (product == "beer")
                {
                    ProductPrice = 1.15M;
                }
                else if (product == "sweets")
                {
                    ProductPrice = 1.30M;
                }
                else
                {
                    ProductPrice = 1.50M;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    ProductPrice = 0.45M;
                }
                else if (product == "water")
                {
                    ProductPrice = 0.70M;
                }
                else if (product == "beer")
                {
                    ProductPrice = 1.10M;
                }
                else if (product == "sweets")
                {
                    ProductPrice = 1.35M;
                }
                else
                {
                    ProductPrice = 1.55M;
                }
            }

            decimal TotalPrice = ProductPrice * quantity;

            Console.WriteLine("The total price is {0:C}", TotalPrice);
        }
    }
}
