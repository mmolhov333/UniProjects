using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {

            var city = Console.ReadLine();
            decimal sales = decimal.Parse(Console.ReadLine());
            
            switch (city.ToLower())
            {
                case "sofia":
                    if (0 <= sales && sales <= 500)
                    {
                        decimal cms = sales * 0.05M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        decimal cms = sales * 0.07M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        decimal cms = sales * 0.08M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (sales > 10000)
                    {
                        decimal cms = sales * 0.12M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "varna":
                    if (0 <= sales && sales <= 500)
                    {
                        decimal cms = sales * 0.045M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        decimal cms = sales * 0.075M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        decimal cms = sales * 0.1M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (sales > 10000)
                    {
                        decimal cms = sales * 0.13M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "plovdiv":
                    if (0 <= sales && sales <= 500)
                    {
                        decimal cms = sales * 0.055M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (500 < sales && sales <= 1000)
                    {
                        decimal cms = sales * 0.08M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (1000 < sales && sales <= 10000)
                    {
                        decimal cms = sales * 0.12M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else if (sales > 10000)
                    {
                        decimal cms = sales * 0.145M;
                        Console.WriteLine("{0:f2}", cms);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default: Console.WriteLine("error");
                    break;
            }

        }
    }
}
