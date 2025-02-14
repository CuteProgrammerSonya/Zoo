using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // class for calculating animals and objects and getting a unique number
    public static class InventoryManager
    {
        private static int Count = 0;
        public static int GetNumber()
        {
            Count += 1; // creating an object
            return Count;
        }
    }
}
