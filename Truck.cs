﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignExercise
{
    public class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Building a new truck!");
        }
    }
}
