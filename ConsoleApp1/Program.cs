using System;

namespace LabØvelse2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 1:

            int BSUKonto = 55000;
            double rente = 6.1;

            double renteInntekt = BSUKonto * (rente / 100);
            double total = BSUKonto + renteInntekt;

            int bruttoSkatt = 21356;
            int nettoSkatt = bruttoSkatt - 2750;

            Console.WriteLine(renteInntekt);
            Console.WriteLine(nettoSkatt);
            Console.WriteLine(total);
            Console.ReadLine();


            //Øvelse 2:

            int arbeidsdag = int.Parse(Console.ReadLine());
            if (arbeidsdag < 1 | arbeidsdag > 7)
            {
                Console.WriteLine("Ugyldig");
            }

            if (arbeidsdag > 0 && arbeidsdag < 6)
            {
                Console.WriteLine("Arbeidsdag");
            }
            else
            {
                Console.WriteLine("Helg");
            }


            //Øvelse 3:
            Console.WriteLine("Enter 2 numbers: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x == y)
            {
                Console.WriteLine("The numbers are equal");
            }

            else if (x > y)
            {
                Console.WriteLine(x + "is biggest");
            }
            else
            {
                Console.WriteLine(y + "is biggest");
            }


            //Øvelse 4:

            Person arthur = new Person();
            arthur.ID = 1;
            arthur.Name = "Arthur Bergersen";
            arthur.DateOfBirth = DateTime.Parse("01.01.1970");
            arthur.Address = "Heibergs gate 2B";

            while (true)
            {
                Console.WriteLine(arthur.Search(arthur, Console.ReadLine()));
            }
        }
    }
}