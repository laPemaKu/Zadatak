using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class CompetitionEntry
    {
        Teacher teacher;
        Dessert dessert;
        List<Student> students = new List<Student>();
        double[] ocjene = new double[3];
        int ratings=0;
        

        public CompetitionEntry()
        {

        }
        public CompetitionEntry(Teacher teacher, Dessert dessert, List<Student> students, double[] ocjene)
        {
            this.teacher = teacher;
            this.dessert = dessert;
            this.students = students;
            this.ocjene = ocjene;
        }

        public CompetitionEntry(Teacher teacher, Dessert dessert)
        {
            this.teacher = teacher;
            this.dessert = dessert;
        }

        public double[] Ocjene { get => ocjene; set => ocjene = value; }
        internal Teacher Teacher { get => teacher; set => teacher = value; }
        internal Dessert Dessert { get => dessert; set => dessert = value; }
        internal List<Student> Students { get => students; set => students = value; }

        public bool AddRating(Student student, int grade)
        {
            bool newStudent = true;
            foreach (Student ucenik in students)
            {
                if (ucenik != student)
                {
                    newStudent = true;
                }
                else
                {
                    newStudent = false;
                    break;
                }
            }
            if (newStudent == true)
            {
                if (ratings >= 3)
                {
                    return false;
                }
                else
                {
                    students.Add(student);
                    ocjene[ratings] = grade;
                    ratings++;
                    return true;

                }
            }
            else
            {
                return false;
            }
        }

        public double GetRating()
        { 
            if(ratings == 0)
            {
                return 0;
            }
            double ukupno=0;
            foreach(int ocjena in ocjene)
            {
                ukupno += ocjena;
            }
            double prosjecna = ukupno / ratings;
            ratings = 0;
            return prosjecna;
        }
    }
}
