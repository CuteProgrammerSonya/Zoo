using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // class with implementation of interface IClinic
    public class Clinic
    {
        public bool CheckHealth(Animal animal)
        {
            if (animal.Health > 5) // checking Animal health
            {
                Console.WriteLine($"Health is ok. A(n) {animal.Affiliation} {animal.Name} is suitable for our zoo!\n"); // it's ok
                return true;
            }
            else
            {
                Console.WriteLine($"Health is not ok. A(n) {animal.Affiliation} {animal.Name} is not suitable for our zoo.\n"); // it's not ok
                return false;
            }
        }
    }
}
