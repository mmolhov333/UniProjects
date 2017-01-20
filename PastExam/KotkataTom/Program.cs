using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotkataTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workingDays = 365 - daysOff;
            int PTdaysOff = daysOff * 127;
            int PTworkingDays = workingDays * 63;
            int totalPT = PTdaysOff + PTworkingDays;

            int deviation = 30000 - totalPT;
            int hours = Math.Abs(deviation) / 60;
            int minutes = Math.Abs(deviation) % 60;

            if (deviation < 0)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
