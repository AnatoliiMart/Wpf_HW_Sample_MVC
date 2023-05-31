using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_HW_Sample_MVC.Models
{
    public class Person
    {
        public Person(string name, int age) { Name = name; Age = age; }

        public string Name { get; set; }
        public int Age { get; set; } = 18;

        public override string ToString() => $"Name: {Name}\n\t Age: {Age}";
    }
}
