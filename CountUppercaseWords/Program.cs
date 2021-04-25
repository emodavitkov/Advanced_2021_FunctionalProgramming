using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            // Func<string, bool> checker = n => n[0] == n.ToUpper()[0];  
            Func<string, bool> checker = word => char.IsUpper(word[0]);

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
