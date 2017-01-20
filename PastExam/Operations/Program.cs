using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            string mathOperator = Console.ReadLine();

            if (mathOperator == "+")
            {
                string numbertype = "";
                int result = firstnumber + secondnumber;

                if (result % 2 == 0)
                {
                    numbertype = "even";
                }
                else
                {
                    numbertype = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstnumber, mathOperator, secondnumber, result, numbertype);
            }
            else if (mathOperator == "-")
            {
                string numbertype = "";
                int result = firstnumber - secondnumber;

                if (result % 2 == 0)
                {
                    numbertype = "even";
                }
                else
                {
                    numbertype = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstnumber, mathOperator, secondnumber, result, numbertype);
            }
            else if (mathOperator == "*")
            {
                string numbertype = "";
                int result = firstnumber * secondnumber;

                if (result % 2 == 0)
                {
                    numbertype = "even";
                }
                else
                {
                    numbertype = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", firstnumber, mathOperator, secondnumber, result, numbertype);
            }
            else if (mathOperator == "/")
            {
                if (secondnumber != 0)
                {
                    double result = firstnumber / (double)secondnumber;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", firstnumber, mathOperator, secondnumber, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstnumber);
                }
                
            }
            else
            {
                if (secondnumber != 0)
                {
                    int result = firstnumber % secondnumber;
                    Console.WriteLine("{0} {1} {2} = {3}", firstnumber, mathOperator, secondnumber, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", firstnumber);
                }
            }
          
        }
    }
}
