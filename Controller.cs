using System.Collections.Generic;
using Wpf_HW_Sample_MVC.Models;

namespace Wpf_HW_Sample_MVC
{
    public class Controller
    {
        private readonly DB _dB = new DB();


        public Controller() { }


        public void AddPersonToDB(string name, int age) => _dB.AddPerson(new Person(name, age));

        public List<Person> GetAll() => _dB.GetPersons();

        public List<Person> SearchPersons(string name) => _dB.GetPersons(name);

        public void Delete(Person person) => _dB.DeletePerson(person);
    }
}
