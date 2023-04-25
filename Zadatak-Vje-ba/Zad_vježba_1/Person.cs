using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Person
    {
        public string name, surname;
        int age;

        public Person()
        {
        }

        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   name == person.name &&
                   surname == person.surname &&
                   age == person.age;
        }

        public override int GetHashCode()
        {
            int hashCode = -1402489640;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "Ime: " + name + ", Prezime: " + surname + ", Godine: " + age;
        }


    }
}
