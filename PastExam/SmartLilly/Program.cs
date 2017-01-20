using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {

            int lillysage = int.Parse(Console.ReadLine());
            double wmprice = double.Parse(Console.ReadLine());
            int toyprice = int.Parse(Console.ReadLine());

            int giftmoney = 10;
            int totalgiftmoney = 0;
            int totaltoys = 0;

            for (int i = 1; i <= lillysage; i++)
            {
                if (i % 2 == 0)
                {
                    totalgiftmoney += (giftmoney -1);
                    giftmoney += 10;
                }
                else
                {
                    totaltoys++;
                }
            }

            int toyvalue = totaltoys * toyprice;
            totalgiftmoney += toyvalue;
            double difference = totalgiftmoney - wmprice;

            if (difference >= 0)
            {
                Console.WriteLine("Yes! {0:f2}", difference);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(difference));
            }

        }
    }
}
