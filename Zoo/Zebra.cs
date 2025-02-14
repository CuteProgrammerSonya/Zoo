using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zebra : Herbivorous
    {
        // an example of different Classes in Animal->Herbivorous
        public Zebra(string name, int health, int food, int kindness) : base(name, health, food, kindness)
        {
            Affiliation = "zebra";
        }
    }
}
