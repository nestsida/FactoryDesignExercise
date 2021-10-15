using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExercise
{
    static class VehicleFactory
    {
     
         public static IVehicle GetVehicle(int userInput) 
        {
            switch(userInput)
            {
                case 4:
                    return new Car();
                case 2:
                case 3:
                    return new Truck();
             
                default:
                    return new Car();
                   break;
            }
        }
    }
}
