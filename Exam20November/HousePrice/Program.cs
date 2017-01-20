using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {

            double smallRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double SqMprice = double.Parse(Console.ReadLine());

            double bathroomArea = smallRoomArea / 2;
            double secondRoomArea = (smallRoomArea + (0.1 * smallRoomArea));
            double thirdRoomArea = (secondRoomArea + (0.1 * secondRoomArea));
            double wholeArea = (smallRoomArea + kitchenArea + bathroomArea + secondRoomArea + thirdRoomArea);
            double hallway = wholeArea * 0.05;
            double finalArea = wholeArea + hallway;
            double totalPrice = finalArea * SqMprice;

            Console.WriteLine("{0:f2}", totalPrice);

        }
    }
}
