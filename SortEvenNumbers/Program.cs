using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = Console.ReadLine()
                .Split(",",StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                 .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToArray();

            

            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
