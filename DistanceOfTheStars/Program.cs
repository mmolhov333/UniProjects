using System;

namespace DistanceOfTheStars
{
    class Program
    {
        static void Main()
        {

            decimal ly = 9450000000000;

            decimal earthToNearestStar = ly * 4.22m;
            decimal centerOfTheMilkyWay = ly * 26000m;
            decimal dmOfTheMilyWay = ly * 100000m;
            decimal earthToTheEdge = ly * 46500000000m;

            Console.WriteLine($"{earthToNearestStar:e2}");
            Console.WriteLine($"{centerOfTheMilkyWay:e2}");
            Console.WriteLine($"{dmOfTheMilyWay:e2}");
            Console.WriteLine($"{earthToTheEdge:e2}");

        }
    }
}
