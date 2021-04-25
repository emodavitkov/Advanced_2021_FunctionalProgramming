using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int[], int> SmallestNumber = x => x.Min();
            Func<int[], int> SmallestNumber =
                numbers =>

                {
                    int minNum = int.MaxValue;

                    foreach (int num in numbers)
                    {

                        if (num < minNum)
                        {
                            minNum = num;
                        }

                    }
                    return minNum;
                };

            int[] digits = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            //Console.WriteLine(SmallestNumber(digits));

            int numNumber = SmallestNumber(digits);
            Console.WriteLine(numNumber);

        }
    }
}
