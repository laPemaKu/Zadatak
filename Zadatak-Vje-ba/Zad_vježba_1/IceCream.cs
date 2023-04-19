using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class IceCream : Dessert
    {
        string flavor, color;
        public IceCream(string name, double weight, int calories, string flavor, string color) : base(name, weight, calories)
        {
            this.flavor = flavor;
            this.color = color;
        }
        public string Flavor { get => flavor; set => flavor = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            return base.ToString() + ", Flavor:" + flavor + ", Color: " + color;
        }
        public new string GetDessertType()
        {
            return "Ice cream";
        }
    }
}
