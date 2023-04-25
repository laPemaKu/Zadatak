using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Car : Vehicle
    {
        string carType;
        public Car(string regNo, string model, int year, double price, string carType) : base(regNo, model, year, price)
        {
            this.carType = carType;
        }

        public string CarType { get => carType; set => carType = value; }
    }
}
