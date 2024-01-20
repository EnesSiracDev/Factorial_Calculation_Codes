using System;

namespace FactorialCalculationCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using the "for"
            /*
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            Console.Write("Result: {0}", factorial);

            */

            // Using the "while" 

            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            while (number > 0)
            {
                factorial = factorial * number;

                number--;
            }
            Console.Write("Result: {0}", factorial);

            Console.ReadKey();
        }
    }
}
