using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseАndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reverses a collection and removes elements that are divisible by a given integer n. 
            //Use predicates/ functions.

            int[] collection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int, int, bool> filter = (num,n) => num % n != 0;

            collection = collection.Where(num => filter(num,n)).ToArray();

            Console.WriteLine(String.Join(" ",collection));
        }
    }
}
