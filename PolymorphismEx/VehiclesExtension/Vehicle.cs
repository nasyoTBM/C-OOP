using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public double TankCapacity
        {
            get { return tankCapacity; }
            set {tankCapacity = value;}
        }
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            this.tankCapacity = tankCapacity;
            if (this.tankCapacity < this.fuelQuantity)
            {
                this.fuelQuantity = 0;
            }
            
        }

        public void Drive(double km)
        {
            double litersToDrive = km * FuelConsumption;
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
        public abstract void Refuel(double liters);
        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:F2}";
        }
    }
}
