using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // the successor class
    public class Herbivorous : Animal
    {
        public int Kindness { get; private set; } // the level of kidness
        public Herbivorous(string name, int health, int food, int kindness) : base(name, health, food)
        {
            Affiliation = "herbivorous";
            Kindness = kindness;
        }
        // checking kidness for contact zoo
        public bool CheckKidness()
        {
            if (Kindness > 5)
            {
                //Console.WriteLine("This animal is suitable for contact zoo. It's kind!"); // it's ok
                return true;
            }
            else
            {
                //Console.WriteLine("This animal is not suitable for contact zoo. It's not enough kind!"); // it's not ok
                return false;
            }
        }
    }
}
