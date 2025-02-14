using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // class with implementation of zoo interface
    public class MyZoo : IMyZoo
    {
        // all objects in zoo
        private readonly List<Animal> Animals = new List<Animal>();
        private readonly List<Thing> Things = new List<Thing>();
        private readonly List<Employee> Employees = new List<Employee>();
        public IReadOnlyList<Animal> animals => Animals.AsReadOnly(); // for reading
        // an animal clinic
        private readonly Clinic Clinic;
        // initialization of a clinic
        public MyZoo(Clinic Clinic)
        {
            this.Clinic = Clinic;
        }
        public void AddAnimal(Animal animal)
        {
            if (Clinic.CheckHealth(animal)) // if health is ok
            {
                Animals.Add(animal);
            }
        }
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            Console.WriteLine($"An employee {employee.Name} was added.\n");
        }

        public void AddThing(Thing thing)
        {
            Things.Add(thing);
            Console.WriteLine($"{thing.Affiliation} was added.\n");
        }
        public void GetSumAnimalFood()
        {
            int count = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                count += Animals[i].Food;
            }
            Console.WriteLine($"There are {Animals.Count} animals in our zoo. They need to {count} kg food per a day.\n");
        }
        public void GetContactAnimals()
        {
            List<Herbivorous> Herbs = Animals.OfType<Herbivorous>().ToList();
            Console.WriteLine($"The list of animals for a contact zoo:\n");
            for (int i = 0; i < Herbs.Count; i++)
            {
                if (Herbs[i].CheckKidness())
                {
                    Console.WriteLine($"{Herbs[i].Affiliation} {Herbs[i].Name}\n");
                }
            }
        }
        public void GetEmployees()
        {
            Console.WriteLine($"There are {Employee.GetEmployeeCount()} workers in our zoo:\n");
            for (int i = 0; i < Employees.Count; i++)
            {
                Console.WriteLine($"{Employees[i].Name}\n");
            }
        }
        public void FeedAnimal(Animal animal)
        {
            if (Animals.Contains(animal))
            {
                animal.Feed();
            }
            else
            {
                Console.WriteLine($"A(n) {animal.Affiliation} {animal.Name} not in our zoo.\n");
            }
        }
        public void TakeInventory()
        {
            Console.WriteLine("Animals in our zoo:\n");
            for (int i = 0; i < Animals.Count; i++)
            {
                Console.WriteLine($"{Animals[i].Number} - {Animals[i].Affiliation} {Animals[i].Name} - eat {Animals[i].Food} kg food per a day\n");
            }
            Console.WriteLine("Things in our zoo:\n");
            for (int i = 0; i < Things.Count; i++)
            {
                Console.WriteLine($"{Things[i].Number} - {Things[i].Affiliation}\n");
            }
        }

    }
}
