using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Van : Vehicle
    {
        double height;
        int noOfSeats;
        public Van(string regNo, string model, int year, double price, double height, int noOfSeats) : base(regNo, model, year, price)
        {
            this.height = height;
            this.noOfSeats = noOfSeats;
        }

        public double Height { get => height; set => height = value; }
        public int NoOfSeats { get => noOfSeats; set => noOfSeats = value; }
    }
}
