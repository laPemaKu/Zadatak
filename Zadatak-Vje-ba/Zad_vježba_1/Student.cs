using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Student : Person
    {
        string studentId;
        short academicYear;

        public Student(string name, string surname, int age, string studentId, short academicYear) : base(name, surname, age)
        {
            this.studentId = studentId;
            this.academicYear = academicYear;
        }

        public string StudentId { get => studentId; set => studentId = value; }
        public short AcademicYear { get => academicYear; set => academicYear = value; }

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   base.Equals(obj) &&
                   studentId == student.studentId;
        }

        public override int GetHashCode()
        {
            int hashCode = -2017659757;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(studentId);
            return hashCode;
        }

        public override string ToString()
        {
            return base.ToString() + ", Student Id: " + studentId + ", Academic year: " + academicYear;
        }


    }
}
