using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pgSide = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchHeight = int.Parse(Console.ReadLine());

            int pgArea = pgSide * pgSide;
            int benchArea = benchWidth * benchHeight;
            int areaToCover = pgArea - benchArea;
            double tileArea = tileWidth * tileHeight;
            double tileCount = areaToCover / tileArea;
            double timeElapsed = tileCount * 0.2;

            Console.WriteLine(tileCount);
            Console.WriteLine(timeElapsed);
        }
    }
}
