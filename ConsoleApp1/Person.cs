using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabØvelse2
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public string Search(Person person, string specifier)
        {
            specifier = specifier.ToLower();
            if (specifier == "name")
            {
                return person.Name;
            }
            else if (specifier == "id")
            {
                return person.ID.ToString();
            }
            else if (specifier == "dateofbirth")
            {
                return person.DateOfBirth.ToString();
            }
            else if (specifier == "address")
            {
                return person.Address;
            }
            else
            {
                return "Invalid token";
            }
        }
    }
}