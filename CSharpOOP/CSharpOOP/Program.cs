using System;
using System.Collections.Generic;
using System.Linq;
using CSharpOOP.Models;

namespace CSharpOOP
{

    class Program
    {
        static void Main(string[] args)
        {
            // Generate a Context
            VehicleContext context = new VehicleContext();

            context.Vehicle.Add(new Vehicle()
            {
                Id = 9,
                Manufacturer = "Chevrolet",
                Model = "Corvette",
                ModelYear = 1959,
                Colour = "Red"
            });

            context.SaveChanges();
        }
        
    }
}