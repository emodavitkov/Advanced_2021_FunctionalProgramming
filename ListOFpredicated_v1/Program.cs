using System;
using System.Linq;
using System.Collections.Generic;

namespace ListOFpredicated_v1
{
    class Program
    {
        static void Main(string[] args)
        {

            int end = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> numbers = Enumerable.Range(1, end).ToList();

            //Console.WriteLine(numbers.Any());
            //Console.WriteLine(numbers.Any(n=> n==10));
            //Console.WriteLine(numbers.Any(n=> n==100));

            //Console.WriteLine(numbers.All(num => num%2==0));
            //Console.WriteLine(numbers.All(num => num <=10));

            //option 1 the same as option 2 but with Func

            Func<int, int, bool> predicate =
                (num, d) => num % d == 0; 

            foreach (int num in numbers)
            {
                if (dividers.All(d => predicate(num,d)))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();

            //option 2
            
            //foreach (int num in numbers)
            //{
            //    if (dividers.All(d => num % d==0))
            //    {
            //        Console.Write(num + " ");
            //    }
            //}
            //Console.WriteLine();




            //Func<int, int, List<int>> range = (start, end) =>

            //{
            //    List<int> arrNum = new List<int>();

            //    for (int i = start; i <= end; i++)
            //    {
            //        arrNum.Add(i);
            //    }
            //    return arrNum;
            //};




        }
    }
}
