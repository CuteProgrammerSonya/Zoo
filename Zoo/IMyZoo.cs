using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // interface for zoo
    public interface IMyZoo
    {
        // add an animal in zoo
        void AddAnimal(Animal animal);
        // add a worker
        void AddEmployee(Employee employee);
        //add thing
        void AddThing(Thing thing);
        // count of food for all animals
        void GetSumAnimalFood();
        // get animals for contact zoo
        void GetContactAnimals();
        // get employees
        void GetEmployees();
        // print information about all inventorizational objects
        void TakeInventory();
        // feed an animal
        void FeedAnimal(Animal animal);
        IReadOnlyList<Animal> animals { get; } // for reading
    }
}
