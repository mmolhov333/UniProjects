using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var plr1 = int.Parse(Console.ReadLine());
            var plr2 = int.Parse(Console.ReadLine());
            var plr3 = int.Parse(Console.ReadLine());
            var TotalTime = plr1 + plr2 + plr3;
            var minutes = TotalTime / 60;
            var seconds = TotalTime % 60;

            if (seconds > 9)
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
        }
    }
}
