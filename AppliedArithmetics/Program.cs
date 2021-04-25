using System;
using System.Linq;
using System.Collections.Generic;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //List<int> updatedNumbers = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="end")
                {
                    break;
                }

                Func<int, int> arithmeticFunc = number => number;
                
                Action<List<int>> print =
                    nums => Console.WriteLine(string.Join(" ", nums));

                switch (input)
                {
                    case "add":
                        arithmeticFunc = number => number + 1;
                        numbers = numbers.Select(arithmeticFunc).ToList();
                        break;

                    case "multiply":
                        arithmeticFunc = number => number * 2;
                        numbers = numbers.Select(arithmeticFunc).ToList();
                        break;

                    case "subtract":
                        arithmeticFunc = number => number - 1;
                        numbers = numbers.Select(arithmeticFunc).ToList();
                        break;

                    case "print":
                        print(numbers);
                        break;

                    default:
                        break;
                }
                
                
                 

            }

            //Console.WriteLine(string.Join(" ", numbers));
            //method below not used
        }

      

        static List<int> MyWhere(List<int> numbers, Predicate<int> predicate)
        {
            List<int> newNumbers = new List<int>();

            foreach (int currNum in numbers)
            {
                if (predicate(currNum))
                {
                    newNumbers.Add(currNum);
                }
            }

            return newNumbers;
        }
    }
}
