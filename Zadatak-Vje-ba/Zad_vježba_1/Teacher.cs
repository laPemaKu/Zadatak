using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Teacher : Person
    {
        string email, subject;
        double salary;

        public Teacher(string name, string surname, int age, string email, string subject, double salary) : base(name, surname, age)
        {
            this.email = email;
            this.subject = subject;
            this.salary = salary;
        }

        public string Email { get => email; set => email = value; }
        public string Subject { get => subject; set => subject = value; }
        public double Salary { get => salary; set => salary = value; }

        public override bool Equals(object obj)
        {
            return obj is Teacher teacher &&
                   base.Equals(obj) &&
                   email == teacher.email;
        }

        public override int GetHashCode()
        {
            int hashCode = -1346820515;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(email);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString() + ", Email: " + email + ", Subject: " + subject + ", Salary: " + salary;
        }

        public void IncreaseSalary(int postotak)
        {
            salary = salary * (postotak / 100);
        }

        public static void IncreaseSalary(int postotak, params Teacher[] list)
        {
            foreach(Teacher teacher in list)
            {
                IncreaseSalary(postotak);
            }
        }
    }
}
