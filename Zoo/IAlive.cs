using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // interface with common properties of animals and people
    public interface IAlive
    {
        int Food { get; } // kg food per a day
        string Name { get; } // name of an animal or an employee
    }
}
