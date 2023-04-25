using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class UniMasterChef
    {
        CompetitionEntry entry;
        int numberOfEnteries;
        List<CompetitionEntry> entries = new List<CompetitionEntry>();
        public bool newEntry = true;
        public int upisane = 0;
        List<Person> osobe = new List<Person>();

        public UniMasterChef (int numberOfEnteries)
        {
            
            this.numberOfEnteries = numberOfEnteries;
        }

        public int NumberOfEnteries { get => numberOfEnteries; set => numberOfEnteries = value; }

        public bool AddEntery(CompetitionEntry entry)
        {
            foreach (CompetitionEntry ulaz in entries)
            {
                if (ulaz != entry)
                {
                    newEntry = true;
                }
                else
                {
                    newEntry = false;
                    break;
                }
            }
            if (upisane >= numberOfEnteries)
            {
                return false;
            }
            else
            {
                entries.Add(entry);
                upisane++;
                return true;
            }
        }
        public string getBestDesert()
        {
            List<string> names = new List<string>();
            string name = "", dessert_name = "";
            double best = 0;
            bool tie = false;
            foreach (CompetitionEntry entry in entries)
            {
                if (entry.GetRating() == best)
                {
                    tie = true;
                    names.Add(entry.Teacher.Name);
                }
                if (entry.GetRating() >= best)
                {
                    tie = false;
                    names.Clear();
                    best = entry.GetRating();
                    name = entry.Teacher.Name;
                    dessert_name = entry.Dessert.Name;
                    names.Add(name);
                }
            }
            if (tie == true)
            {
                return GetTied(names);
            }
            else
            {
                return "The winner is: " + name + " with a " + dessert_name;
            }
        }
        public string GetTied(List<string> names)
        {
            string all_names = "";
            foreach(string name in names)
            {
                all_names += name;
            }
            return "Its a tie, the winners are: " ;
        }
        public List<Person> getInvolvedPeople(CompetitionEntry entry)
        {
            osobe.Clear();
            foreach(Student student in entry.Students)
            {
                osobe.Add(student);
            }
            osobe.Add(entry.Teacher);

            return osobe;
        }
    }
}
