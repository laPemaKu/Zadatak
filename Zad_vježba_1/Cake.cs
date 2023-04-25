using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Cake : Dessert
    {
        bool containsGluten;
        string type;
        public Cake(string name, double weight, int calories, bool containsGluten, string type) : base(name, weight, calories)
        {
            this.containsGluten = containsGluten;
            this.type = type;
        }
        public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
        public string Type { get => type; set => type = value; }

        public override string ToString()
        {
            return base.ToString() + ", Contains Gluten: " + containsGluten + ", Type: " + type;
        }

        public new string GetDessertType()
        {
            return "Cake";
        }
    }
}
