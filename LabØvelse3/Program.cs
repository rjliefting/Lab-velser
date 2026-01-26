using LabØvelse2;
using System;

namespace LabØvelse3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 1
            Console.WriteLine("Do you want to create a Person-object? Enter yes to continue, enter 'exit' to stop:");

            while (Console.ReadLine() != "exit")
            {
                Person person = new Person();
                Console.WriteLine("Enter name: ");
                person.Name = Console.ReadLine();
                Console.WriteLine("Enter date of birth: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                person.DateOfBirth = date;
                Console.WriteLine("Enter address: ");
                person.Address = Console.ReadLine();
                Console.WriteLine("Enter ID: ");
                person.ID = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("End.");

            //Øvelse 2:

            MatteKlasse mK = new MatteKlasse();
            Console.WriteLine("Calculator.");
            Console.WriteLine("Enter Add, Subtract, Multiply or Divide, or Exit to exit: ");
            string cmd = Console.ReadLine().ToLower();
            while (cmd != "exit") 
            { 
                if(cmd == "add")
                {
                    Console.WriteLine("Enter num 1: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 2: ");
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(mK.Add(int1, int2));
                }

                if(cmd == "subtract")
                {
                    Console.WriteLine("Enter num 1: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 2: ");
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(mK.Subtract(int1, int2));
                }

                if (cmd == "multiply")
                {
                    Console.WriteLine("Enter num 1: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 2: ");
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(mK.Multiply(int1, int2));
                }

                if (cmd == "divide")
                {
                    Console.WriteLine("Enter num 1: ");
                    int int1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter num 2: ");
                    int int2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(mK.Divide(int1, int2));
                }

                Console.WriteLine("Enter Add, Subtract, Multiply or Divide, or Exit to exit: ");
                cmd = Console.ReadLine().ToLower();
            }


            //Øvelse 3:

            Console.WriteLine("Enter a number: ");
            Console.WriteLine(int.Parse(Console.ReadLine()) % 2);

            //Øvelse 4:

            Student std = new Student("123", "Per", 12.5m, 11.0m, 19.8m);

            Console.WriteLine(std.GetAggregate());
            Console.WriteLine(std.GetPercentage());
        }
    }
}
