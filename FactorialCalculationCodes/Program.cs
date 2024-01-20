using System;

namespace FactorialCalculationCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Using the "for" 

            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = sayi; i > 0; i--)
            {
                faktoriyel *= i;
            }
            Console.Write("Sonuç: {0}", faktoriyel);

            */

            /* Using the "while" */

            Console.Write("Bir sayı girin: ");
            int sayi = int.Parse(Console.ReadLine());
            int faktoriyel = 1;
            while (sayi > 0)
            {
                faktoriyel = faktoriyel * sayi;

                sayi--;
            }
            Console.Write("Sonuç: {0}", faktoriyel);

            Console.ReadKey();
        }
    }
}
