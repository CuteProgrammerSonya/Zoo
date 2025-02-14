using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // class with implementation of IAlive interface
    public class Employee : IAlive
    {
        public string Name { get; private set; }
        public int Food { get; private set; }
        private static int Count = 0; // the number of employees 
        public Employee(string name, int food)
        {
            Name = name;
            Food = food;
            Count += 1; // a new employee
        }
        public static int GetEmployeeCount() // returning count
        {
            return Count;
        }
    }
}
