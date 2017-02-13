using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main()
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        var value1 = int.Parse(Console.ReadLine());
                        var value2 = int.Parse(Console.ReadLine());
                        var bigger = Max(value1, value2);
                        Console.WriteLine($"{bigger}");
                        break;
                    }
                case "char":
                    {
                        var value1 = char.Parse(Console.ReadLine());
                        var value2 = char.Parse(Console.ReadLine());
                        var bigger = Max(value1, value2);
                        Console.WriteLine($"{bigger}");
                        break;
                    }
                case "string":
                    {
                        var value1 = Console.ReadLine();
                        var value2 = Console.ReadLine();
                        var bigger = Max(value1, value2);
                        Console.WriteLine($"{bigger}");
                        break;
                    }
            }
        }

        static int Max(int int1, int int2)
        {
            if (int1 > int2)
            {
                return int1;
            }
            return int2;
        }

        static char Max(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            return char2;
        }

        static string Max(string str1, string str2)
        {
            if (str1.CompareTo(str2) > 0)
            {
                return str1;
            }
            return str2;
        }
    }

}
