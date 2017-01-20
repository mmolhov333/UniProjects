using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {

            int totalPackages = int.Parse(Console.ReadLine());
            int totaltons = 0;
            double tonsByBus = 0.0;
            double tonsByTruck = 0.0;
            double tonsByTrain = 0.0;
            double busPrice = 200.0;
            double truckPrice = 175.0;
            double trainPrice = 120.0;

            for (int n = 0; n < totalPackages; n++)
            {
                int tons = int.Parse(Console.ReadLine());
                totaltons = totaltons + tons;

                if (tons <= 3)
                {
                    tonsByBus += tons;
                }
                else if (tons <= 11)
                {
                    tonsByTruck += tons;
                }
                else
                {
                    tonsByTrain += tons;
                }
            }

            double totalBusPrice = tonsByBus * busPrice;
            double totalTruckPrice = tonsByTruck * truckPrice;
            double totalTrainPrice = tonsByTrain * trainPrice;
            double totalPrice = totalBusPrice + totalTruckPrice + totalTrainPrice;
            double avgPricePerTon = totalPrice / totaltons;

            double tonsByBusPercentage = (tonsByBus / totaltons) * 100;
            double tonsByTruckPercentage = (tonsByTruck / totaltons) * 100;
            double tonsByTrainPercentage = (tonsByTrain / totaltons) * 100;

            Console.WriteLine("{0:f2}", avgPricePerTon);
            Console.WriteLine("{0:f2}%", tonsByBusPercentage);
            Console.WriteLine("{0:f2}%", tonsByTruckPercentage);
            Console.WriteLine("{0:f2}%", tonsByTrainPercentage);



        }
    }
}
