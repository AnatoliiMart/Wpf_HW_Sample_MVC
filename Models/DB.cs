using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_Sample_MVC.Models
{
    internal class DB
    {
        private List<Person> persons;

        public DB() => persons = new List<Person>();

        public void AddPerson(Person person) => persons.Add(person);

        public List<Person> GetPersons() => persons;

        public List<Person> GetPersons(string Name)
        {
            List<Person> result = new List<Person>();

            var res = from person in persons
                      where person.Name == Name
                      select person;

            foreach (var person in res)
                result.Add(person);

            return result;
        }

        public void DeletePerson(Person person) => persons.Remove(person);
    }
}
