using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("//2. zadatak");
            IceCream vanila = new IceCream("Vanila", 22.2, 43, "Vanila", "yellow");
            Cake cokoladna = new Cake("Čokoladna torta", 22.2, 43, true, "čokoladna");

            Console.WriteLine(vanila.ToString());
            Console.WriteLine(vanila.GetDessertType());

            Console.WriteLine(cokoladna.ToString());
            Console.WriteLine(cokoladna.GetDessertType());

            Console.ReadKey();

            Console.WriteLine("//5. zadatak prvi dio");

            Student student1 = new Student("Pero", "Perić", 20, "id888", (short)2);
            Student student2 = new Student("Ana", "Anić", 20, "id555", (short)1);
            Teacher teacher1 = new Teacher("Anka", "Anković", 35, "ankaankovic@gmail.com", "Baze podataka", 1020);
            Teacher teacher2 = new Teacher("Tomas", "Tomasović", 40, "tomastomasovic@gmail.com", "Algoritmi i programiranje", 1550);
            Teacher teacher3 = new Teacher("Klara", "Klarić", 37, "klaraklaric@gmail.com", "Web dizajn", 2020);

            List<Person> list = new List<Person>();
            list.Add(student1);
            list.Add(student2);
            list.Add(teacher1);
            list.Add(teacher2);
            list.Add(teacher3);

            double salaries = 0;
            foreach (Person person in list)
            {
                Console.WriteLine("Ime: " + person.Name + ", Prezime: " + person.Surname);
                if (person.GetType() == typeof(Teacher))
                {
                    Teacher teacher = person as Teacher;
                    salaries += teacher.Salary;
                }
            }
            Console.WriteLine("Prosjećna plaća: " + salaries/3);

            Console.ReadKey();

            Console.WriteLine("//5. zadatak drugi dio");

            Person p1 = new Person("Ivo", "Ivic", 20);
            Person p2 = new Person("Ivo", "Ivic", 20);
            Person p3 = new Student("Ivo", "Ivic", 20, "0036312123", (short)3);
            Person p4 = new Student("Marko", "Marić", 25, "0036312123", (short)5);

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p3.Equals(p4));

            Console.ReadKey();

            Console.WriteLine("//7. zadatak");
            
            Dessert genericDessert = new Dessert("Chocolate Mousse", 120, 300);
            Cake cake = new Cake("Raspberry chocolate cake #3", 350.5, 400, false, "birthday");

            Teacher t1 = new Teacher("Dario", "Tušek", 42, "dario.tusek@fer.hr", "OOP", 10000);
            Teacher t2 = new Teacher("Doris", "Bezmalinović", 43, "doris.bezmalinovic@fer.hr", "OOP", 10000);

            Student s1 = new Student("Janko", "Horvat", 18, "0036312123", (short)1);
            Student s2 = new Student("Ana", "Kovač", 19, "0036387656", (short)2);
            Student s3 = new Student("Ivana", "Stanić", 19, "0036392357", (short)1);

            UniMasterChef competition = new UniMasterChef(2);

            CompetitionEntry e1 = new CompetitionEntry(t1, genericDessert);
            competition.AddEntery(e1);
            Console.WriteLine("Entry 1 rating: " + e1.GetRating());

            e1.AddRating(s1, 4);
            e1.AddRating(s2, 5);
            Console.WriteLine("Entry 1 rating: " + e1.GetRating());

            CompetitionEntry e2 = new CompetitionEntry(t2, cake);
            e2.AddRating(s1, 4);
            e2.AddRating(s3, 5);
            e2.AddRating(s2, 5);
            competition.AddEntery(e2);
            Console.WriteLine("Entry 2 rating: " + e2.GetRating());

            Console.WriteLine("Best dessert is: " + competition.getBestDesert().Dessert.Name);

            List<Person> e2persons = competition.getInvolvedPeople(e2);
            foreach(Person p in e2persons)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
