using System;
using System.Linq;
using System.Collections.Generic;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> collection = Console.ReadLine()
                .Split(" ")
                .ToList();

            Func<string, int, bool> filter = (n, m) => n.Length<=m;

            collection = collection.Where(word => filter(word,n)).ToList();

            //Console.WriteLine(string.Join(Environment.NewLine,collection));

            Action<List<string>> print =
                names => Console.WriteLine(string.Join(Environment.NewLine, collection));
            print(collection);
        }
    }
}
