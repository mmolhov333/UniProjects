using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int slotOne = 0; slotOne < n; slotOne++)
            {
                for (int slotTwo = 0; slotTwo < n; slotTwo++)
                {
                    for (int slotThree = 0; slotThree < n; slotThree++)
                    {
                        var FirstLetter = (char)(slotOne + 'a');
                        var SecondLetter = (char)(slotTwo + 'a');
                        var ThirdLetter = (char)(slotThree + 'a');

                        Console.WriteLine($"{FirstLetter}{SecondLetter}{ThirdLetter}");
                    }
                }
            }
        }
    }
}
