using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class CargoVan : Van
    {
        double maxLoad;
        public CargoVan(string regNo, string model, int year, double price, double height, int noOfSeats, double maxLoad) : base(regNo, model, year, price, height, noOfSeats)
        {
            this.maxLoad = maxLoad;
        }

        public double MaxLoad { get => maxLoad; set => maxLoad = value; }
    }
}
