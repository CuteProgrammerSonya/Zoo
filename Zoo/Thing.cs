using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // class thing with implementation of IInventory interface
    public abstract class Thing : IInventory
    {
        public string Affiliation { get; protected set; }
        public int Number { get; private set; }
        public Thing()
        {
            Affiliation = "thing";
            Number = InventoryManager.GetNumber(); // unique number
        }
    }
}
