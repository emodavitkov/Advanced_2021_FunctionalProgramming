using System;

namespace FuncsUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadStudents(PrintStudentSoftUni);
        }

        static void ReadStudents(Func<string, int, string> printer)
        {
           int age = 0;
            

            do
            {
                Console.WriteLine("Stident name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Student age: ");
                age = int.Parse(Console.ReadLine());

                Console.WriteLine(printer(name, age));
                
                //Console.WriteLine(PrintStudentSoftUni(name, age));

            } while (age != -1);


        }

        static string PrintStudentSoftUni(string name, int age)
        {
            return $"SoftUni student is {age} and name {name}";
        }

        static string PrintStudentBulgarian(string name, int age)
        {
            return $"Bulgarian student is {age} abd name {name}";
        }

        static string PrintStudentDvoikadjiq(string name, int age)
        {
            return $"2";
        }
    }
}
