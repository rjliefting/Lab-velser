using System;

namespace LabØvelse4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Øvelse 1
            Book book = new Book();
            book.PublishedYear = 2004;

            //Øvelse 2
            UserAccount account = new UserAccount();
            account.EditPassword("nyttPassord");

            //Øvelse 3
            ConfigurationManager manager = new ConfigurationManager();
            manager.Name = "DekkTeamSørlandet";

            //Øvelse 4
            Employee employee = new Employee();
            Console.WriteLine(employee.Name);
            employee.EditSalary(42000);
        }
    }
}