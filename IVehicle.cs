using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExercise
{
    interface IVehicle
    {
        public void Drive() 
        {
      
            Console.WriteLine("Building a new car!");
        }

    }
}
