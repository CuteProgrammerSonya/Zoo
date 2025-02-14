using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // abstract class with common properties of all types of animals
    // implementation of interfaces: IAlive and IInventory
    public abstract class Animal : IAlive, IInventory
    {
        public string Name { get; private set; } // name of the animal
        public int Health { get; private set; } // health of the animal
        public int Food { get; private set; } // implementation of IAlive
        public int Number { get; private set;} // implementation of IInventory
        public string Affiliation { get; protected set; } // type
        public int Hunger { get; set; } // 0 - animal is hungry, 1 - is not hungry
        protected Animal(string name, int health, int food)
        {
            Name = name;
            Affiliation = "animal";
            Health = health;
            Food = food;
            Number = InventoryManager.GetNumber(); // unique number
            Hunger = 0;
        }
        // feeding an animal
        public void Feed()
        {
            if (Hunger == 0)
            {
                Console.WriteLine($"{Affiliation} {Name} is eating.\n");
                Hunger = 1;
            }
            else
            {
                Console.WriteLine($"{Affiliation} {Name} is not hungry.\n");
            }
        }
    }
}
