﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input == "s3cr3t!P@ssw0rd") 
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong Password!");
            }
        }
    }
}
