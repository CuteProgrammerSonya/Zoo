using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // interface with common properties for inventorizational objects (animals and things)
    public interface IInventory
    {
        int Number { get; } // a number of an inventarizational object 
        string Affiliation { get; } // type of inventary object
    }
}
