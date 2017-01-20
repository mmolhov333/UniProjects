using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime dateTime = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            dateTime = dateTime.AddDays(999);
            Console.WriteLine(dateTime.ToString(format));
        }
    }
}
