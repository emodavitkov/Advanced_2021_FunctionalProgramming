using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Func<int, int, List<int>> range = (start, end) =>

            {
                List<int> arrNum = new List<int>();

                for (int i = start; i <= end; i++)
                {
                    arrNum.Add(i);
                }
                return arrNum;
            };

            List<int> myRange = range(1, n);

            List<int> dividers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            bool divideAll = true;

            Func<List<int>, List<int>, List<int>> filter = (x, y) =>
              {
                  List<int> newNumbers = new List<int>();
                  for (int i = 0; i < x.Count; i++)
                  {
                      for (int j = 0; j < y.Count; j++)
                      {`
                          if (x[i]%y[j]!=0)
                          {

                              divideAll = false;
                              continue;
                          }
                      }
                      if (divideAll)
                      {
                          newNumbers.Add(x[i]);
                      }
                      divideAll = true;
                  }
                  return newNumbers;

              };

            List<int> finalNumbers = filter(myRange, dividers);


            Console.WriteLine(string.Join(" ",finalNumbers));


        }
    }
}
