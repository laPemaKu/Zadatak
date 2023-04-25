using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Vehicle
    {
        string regNo, model;
        int year;
        double price;

        public Vehicle(string regNo, string model, int year, double price)
        {
            this.regNo = regNo;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public string RegNo { get => regNo; set => regNo = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return regNo + " " + model + " " + year + " " + price;
        }
    }
}
