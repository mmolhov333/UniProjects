using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            if (number <= 100)
            {
                bonusScore += 5;
            }
            else if (number <= 1000)
            {
                bonusScore = number * 20 / 100;
            }
            else if (number > 1000)
            {
                bonusScore = number * 10 / 100;
            }
            if (number % 2 == 0)
            {
                bonusScore += 1;
            }
            if (number % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(number + bonusScore);
        }
    }
}
