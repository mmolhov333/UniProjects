using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {

            int firstInput = int.Parse(Console.ReadLine());
            int secondInput = int.Parse(Console.ReadLine());

            int tempFirstInput = firstInput;
            int tempSecondInpit = secondInput;

            if (1 > 0)
            {
                firstInput = tempSecondInpit;
                secondInput = tempFirstInput;
            }

            Console.WriteLine(firstInput);
            Console.WriteLine(secondInput);
        }
    }
}
