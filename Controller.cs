using System.Collections.Generic;
using Wpf_HW_Sample_MVC.Models;

namespace Wpf_HW_Sample_MVC
{
    public class Controller
    {
        private DB dB = new DB();

        public void AddPersonToDB(string name, int age) => dB.AddPerson(new Person(name, age));

        public List<Person> GetAll() => dB.GetPersons();

        public List<Person> SearchPersons(string name) => dB.GetPersons(name);

        public void Delete(Person person) => dB.DeletePerson(person);
    }
}
