using System;

namespace CalculateTriangleArea
{
    class Program
    {
        static void Main()
        {
            var trBase = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var trArea = CalculateArea(trBase, height);

            Console.WriteLine(trArea);
        }

         static double CalculateArea(double trBase, double height)
        {
            var area = (trBase * height) / 2;
            return area;
        }
    }
}