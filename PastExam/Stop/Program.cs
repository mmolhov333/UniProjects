using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int topRowDots = n + 1;
            int wholeWidth = ((n + 1) * 2) + ((2 * n) + 1);

            Console.WriteLine("{0}{1}{0}", new string('.', topRowDots), new string ('_', (2 * n) +1));

            for (int currRow = 1; currRow <= n; currRow++)
            {
                int CurrentDots = topRowDots - currRow;
                int underscores = wholeWidth - (CurrentDots * 2) - 4;
                Console.WriteLine(@"{0}//{1}\\{0}", new string ('.', CurrentDots), new string ('_', underscores));
            }

            int midRowUnderscores = (wholeWidth - 9) / 2;
            Console.WriteLine(@"//{0}STOP!{0}\\", new string ('_', midRowUnderscores));

            for (int currRow = 0; currRow < n; currRow++)
            {
                int CurrentDots = currRow;
                int underscores = wholeWidth - (CurrentDots * 2) - 4;
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', CurrentDots), new string('_', underscores));
            }

        }
    }
}
