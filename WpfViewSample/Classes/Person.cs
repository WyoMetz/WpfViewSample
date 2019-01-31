using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfViewSample.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Char MI { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }

        public List<Person> GetPeople() //Generates a generic list of people.
        {
            List<Person> PeopleList = new List<Person>();

            for (int i = 0; i < 200; i++)
            {
                PeopleList.Add(new Person
                {
                    FirstName = $"First Name {i}",
                    LastName = $"Last Name {i}",
                    MI = 'A',
                    Address = $"{i} {i + 1} {i + 2} Street City State",
                    Number = i
                });
            }
            return PeopleList;
        }
    }
}
