using System;
using System.Collections.Generic;
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
        public CompetitionEntry getBestDesert()
        {
            CompetitionEntry best = new CompetitionEntry();
            
            foreach(CompetitionEntry entry in entries)
            {
                if (entry.GetRating() > best.GetRating())
                {
                    best = entry;
                }
            }

            return best;
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
