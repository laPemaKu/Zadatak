using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_vježba_1
{
    internal class Dessert
    {
        string name;
        double weight;
        int calories;

        public Dessert(string name, double weight, int calories)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Calories { get => calories; set => calories = value; }

        public override string ToString()
        {
            return "Name: " + name + ", Weight: " + weight + ", Calories: " + calories;
        }
        public string GetDessertType()
        {
            return "dessert";
        }
    }
}
