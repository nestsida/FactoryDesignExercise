using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExercise
{
    public class Car : IVehicle
    {
        public string Brand { get; set; }
        public string Fuel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Building a new car!");
        }
    }
}