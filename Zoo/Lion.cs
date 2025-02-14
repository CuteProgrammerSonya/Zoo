using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // an example of different Classes in Animal->Predator
    public class Lion : Predator
    {
        public Lion(string name, int health, int food) : base(name, health, food)
        {
            Affiliation = "lion";
        }
    }
}
