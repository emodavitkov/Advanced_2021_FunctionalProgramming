using System;
using System.Linq;

namespace KnightsofHonor
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] names = Console.ReadLine()
                .Split(" ")
                .Select(name => $"Sir {name}")
                .ToArray();

            Action<string[]> Print =
                name => Console.WriteLine(string.Join(Environment.NewLine,name));

            Print(names);
        }
    }
}
