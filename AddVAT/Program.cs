using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .Select(Decimal.Parse)
                .Select(number => number + (number*0.2m))
                .ToArray();

            foreach (var price in numbers)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
