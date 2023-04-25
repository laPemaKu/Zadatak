using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class PassengerVan : Van
    {
        private int noOfPassengers;
        public PassengerVan(string regNo, string model, int year, double price, double height, int noOfSeats,int noOfPassengers) : base(regNo, model, year, price, height, noOfSeats)
        {
            this.noOfPassengers = noOfPassengers;
        }

        public int NoOfPassengers { get => noOfPassengers; set => noOfPassengers = value; }
    }
}
