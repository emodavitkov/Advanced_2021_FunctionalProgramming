﻿using System;
using System.Linq;

namespace SumNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Func<string, int> parser = n => int.Parse(n);
            
            int[] numbers = input
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());

        }
    }
}
