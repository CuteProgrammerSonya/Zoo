using Zoo;
// creating DI container
DIContainer container = new DIContainer();

// registration of our first service - Clinic 
container.Register<Clinic>(() => new Clinic());

//  registration of MyZoo with dependence on Clinic
container.Register<IMyZoo>(() => new MyZoo(container.Resolve<Clinic>()));

// permission of MyZoo to use
var myZoo = container.Resolve<IMyZoo>();

//example of using
/*
var rabbit = new Rabbit("Roger", 10, 2, 6);
var zebra = new Zebra("Samanta", 6, 6, 5);
var monkey = new Monkey("David", 4, 5, 4);
var lion = new Lion("Chander", 10, 10);
var tiger = new Tiger("Rajah", 9, 10);
var wolf = new Wolf("Luna", 6, 7);
var table = new Table();
var chair = new Chair();
var computer = new Computer();
var worker_1 = new Employee("Maria", 1);
var worker_2 = new Employee("Vasya", 3);

myZoo.AddAnimal(rabbit);
myZoo.AddAnimal(zebra);
myZoo.AddAnimal(monkey);
myZoo.AddAnimal(lion);
myZoo.AddAnimal(tiger);
myZoo.AddAnimal(wolf);

myZoo.AddEmployee(worker_1);
myZoo.AddEmployee(worker_2);

myZoo.AddThing(table);
myZoo.AddThing(chair);
myZoo.AddThing(computer);

myZoo.FeedAnimal(rabbit);
myZoo.FeedAnimal(zebra);
myZoo.FeedAnimal(monkey);
myZoo.FeedAnimal(lion);
myZoo.FeedAnimal(tiger);
myZoo.FeedAnimal(wolf);
myZoo.FeedAnimal(rabbit);

myZoo.GetEmployees();

myZoo.GetSumAnimalFood();

myZoo.GetContactAnimals();

myZoo.TakeInventory();
*/

Console.WriteLine("This is a console interface for working with our zoo.");
Console.WriteLine("You can make some commands:");
Console.WriteLine("1 - add an animal in our zoo");
Console.WriteLine("2 - add an employee in our zoo");
Console.WriteLine("3 - add thing in our zoo");
Console.WriteLine("4 - feed an animal in our zoo");
Console.WriteLine("5 - get list of animals for a contact zoo");
Console.WriteLine("6 - get all employees in our zoo");
Console.WriteLine("7 - get total summ of all animal's food");
Console.WriteLine("8 - check inventarization");
Console.WriteLine("9 - show menu");
Console.WriteLine("0 - finish working with our zoo");
while (true)
{
    Console.Write("\nWrite your command: ");
    int command = Convert.ToInt32(Console.ReadLine());
    if (command == 0)
    {
        break;
    }
    else if (command == 1)
    {
        Console.WriteLine("Add an animal from this list:\n");
        Console.WriteLine("11 - lion");
        Console.WriteLine("12 - monkey");
        Console.WriteLine("13 - rabbit");
        Console.WriteLine("14 - tiger");
        Console.WriteLine("15 - wolf");
        Console.WriteLine("16 - zebra");
        Console.Write("Write a number: ");
        int type = Convert.ToInt32(Console.ReadLine());
        while (type < 11 || type > 16)
        {
            Console.Write("Write a correct number: ");
            type = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Input its name: ");
        string? name = Console.ReadLine();
        Console.Write("Input its health (a number in range from 1 to 10): ");
        int health = Convert.ToInt32(Console.ReadLine());
        while (health < 1 || health > 10)
        {
            Console.Write("Input correct its health (a number in range from 1 to 10): ");
            health = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Input kg food per a day (integer): ");
        int food = Convert.ToInt32(Console.ReadLine());
        while (food <= 0)
        {
            Console.Write("Input correct kg food per a day (integer): ");
            food = Convert.ToInt32(Console.ReadLine());
        }
        int kind = 0;
        if (type == 12 || type == 13 || type == 16)
        {
            Console.Write("Input a level of kindness (a number in range from 1 to 10): ");
            kind = Convert.ToInt32(Console.ReadLine());
            while (kind < 1 || kind > 10)
            {
                Console.Write("Input correct a level of kindness (a number in range from 1 to 10): ");
                kind = Convert.ToInt32(Console.ReadLine());
            }
        }
        if (type == 11)
        {
            var animal = new Lion(name, health, food);
            myZoo.AddAnimal(animal);
        }
        else if (type == 14)
        {
            var animal = new Tiger(name, health, food);
            myZoo.AddAnimal(animal);
        }
        else if (type == 15)
        {
            var animal = new Wolf(name, health, food);
            myZoo.AddAnimal(animal);
        }
        else if (type == 12)
        {
            var animal = new Monkey(name, health, food, kind);
            myZoo.AddAnimal(animal);
        }
        else if (type == 13)
        {
            var animal = new Rabbit(name, health, food, kind);
            myZoo.AddAnimal(animal);
        }
        else
        {
            var animal = new Zebra(name, health, food, kind);
            myZoo.AddAnimal(animal);
        }
    }
    else if (command == 2)
    {
        Console.WriteLine("Add an enployee in our zoo.");
        Console.Write("Input his/her name: ");
        string? name = Console.ReadLine();
        Console.Write("Input kg food per a day (integer): ");
        int food = Convert.ToInt32(Console.ReadLine());
        while (food <= 0)
        {
            Console.Write("Input correct kg food per a day (integer): ");
            food = Convert.ToInt32(Console.ReadLine());
        }
        var worker = new Employee(name, food);
        myZoo.AddEmployee(worker);
    }
    else if (command == 3)
    {
        Console.WriteLine("Add thing from this list:\n");
        Console.WriteLine("31 - table");
        Console.WriteLine("32 - chair");
        Console.WriteLine("33 - computer");
        Console.Write("Write a number: ");
        int type = Convert.ToInt32(Console.ReadLine());
        while (type < 31 || type > 33)
        {
            Console.Write("Write a correct number: ");
            type = Convert.ToInt32(Console.ReadLine());
        }
        if (type == 31)
        {
            var thing = new Table();
            myZoo.AddThing(thing);
        }
        else if (type == 32)
        {
            var thing = new Chair();
            myZoo.AddThing(thing);
        }
        else
        {
            var thing = new Computer();
            myZoo.AddThing(thing);
        }
    }
    else if (command == 4)
    {
        Console.WriteLine("You can feed an animal.\n");
        Console.Write("Input its name: ");
        string? name = Console.ReadLine();
        try
        {
            Animal animal = myZoo.animals.FirstOrDefault(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            myZoo.FeedAnimal(animal);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Animal with name {name} not found in the zoo.");
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
    else if (command == 5)
    {
        myZoo.GetContactAnimals();
    }
    else if (command == 6)
    {
        myZoo.GetEmployees();
    }
    else if (command == 7)
    {
        myZoo.GetSumAnimalFood();
    }
    else if (command == 8)
    {
        myZoo.TakeInventory();
    }
    else if (command == 9)
    {
        Console.WriteLine("You can make some commands:");
        Console.WriteLine("1 - add an animal in our zoo");
        Console.WriteLine("2 - add an employee in our zoo");
        Console.WriteLine("3 - add thing in our zoo");
        Console.WriteLine("4 - feed an animal in our zoo");
        Console.WriteLine("5 - get list of animals for a contact zoo");
        Console.WriteLine("6 - get all employees in our zoo");
        Console.WriteLine("7 - get total summ of all animal's food");
        Console.WriteLine("8 - check inventarization");
        Console.WriteLine("9 - show menu");
        Console.WriteLine("0 - finish working with our zoo");
    }
}