using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    // animal clininc interface with checking health method
    public interface IClinic
    {
        bool CheckHealth(Animal animal);
    }
}
