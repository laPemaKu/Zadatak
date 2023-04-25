using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Limo : Vehicle
    {
        double lenght;
        bool miniBar, sunRoof;
        public Limo(string regNo, string model, int year, double price, double lenght, bool miniBar, bool sunRoof) : base(regNo, model, year, price)
        {
            this.lenght = lenght;
            this.miniBar = miniBar;
            this.sunRoof = sunRoof;
        }

        public double Lenght { get => lenght; set => lenght = value; }
        public bool MiniBar { get => miniBar; set => miniBar = value; }
        public bool SunRoof { get => sunRoof; set => sunRoof = value; }
    }
}
