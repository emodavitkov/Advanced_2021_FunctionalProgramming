using System;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Action<string[]> Print = word => Console.WriteLine(String.Join(Environment.NewLine,word));

            Print(words);
            //the same with method
        //    PrintWord(words);
            
        }

        //static void PrintWord(string[] test) 
        //{
        //    Console.WriteLine(String.Join(Environment.NewLine, test));
        //}
    }
}
