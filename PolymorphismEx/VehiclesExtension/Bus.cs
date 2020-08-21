using System;
using System.Collections.Generic;
using System.Text;
using Vehicles;
using VehiclesExtension;


namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
           : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += 1.4;
        }
        public void DriveEmpty(double km)
        {
            double litersToDrive = km * (FuelConsumption-1.4);
            if (this.FuelQuantity >= litersToDrive)
            {
                this.FuelQuantity -= litersToDrive;
                Console.WriteLine($"{this.GetType().Name} travelled {km} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else if (FuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += liters;
            }

        }
        
    }
}
