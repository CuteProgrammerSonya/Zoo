using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // the successor class
    public class Predator : Animal
    {
        public Predator(string name, int health, int food): base(name, health, food)
        {
            Affiliation = "predator";
        }
    }
}
