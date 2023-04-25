using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Tied
    {
        CompetitionEntry entry1;
        CompetitionEntry entry2;
        double points;

        public Tied(CompetitionEntry entry1, CompetitionEntry entry2, double points)
        {
            this.entry1 = entry1;
            this.entry2 = entry2;
            this.points = points;
        }

        internal CompetitionEntry Entry1 { get => entry1; set => entry1 = value; }
        internal CompetitionEntry Entry2 { get => entry2; set => entry2 = value; }
        internal double Points { get => points; set => points = value; }

        public string GetTied()
        {
            return entry1.Dessert + " " + entry1.Teacher + " and " + entry2.Dessert + " " + entry2.Teacher + " are tied with " + points + " points"; 
        }
    }
}
