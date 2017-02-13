using System;

namespace Greeting
{
    class Program
    {
        static void Main()
        {

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            int ageNum = int.Parse(age);

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {ageNum} years old.");
        }
    }
}
