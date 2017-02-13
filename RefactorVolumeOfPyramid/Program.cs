﻿using System;

namespace RefactorVolumeOfRectangularPyramid
    {
        class Program
        {
            static void Main()
            {

                Console.Write("Length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Width: ");
                double width = double.Parse(Console.ReadLine());

                Console.Write("Height: ");
                double height = double.Parse(Console.ReadLine());

                double Volume = (length * width * height) / 3;
                Console.WriteLine($"Pyramid Volume: {Volume:f2}");
            }
        }
    }
