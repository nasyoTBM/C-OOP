using System;
using System.Linq;
using Vehicles;

namespace VehiclesExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = null;
            Vehicle truck = null;
            Vehicle bus = null;
            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                
                switch (input[0].ToLower())
                {
                    case "car":
                        Vehicle carr = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        car = carr;
                        break;
                    case "truck":
                        Vehicle truckk = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        truck = truckk;
                        break;
                    case "bus":
                        Vehicle buss = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                        bus = buss;
                        break;
                    default:
                        break;
                }
            }
            

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (command[1].ToLower())
                {
                    case "car":
                        if (command[0].ToLower() == "drive")
                        {
                            (car as Car).Drive(double.Parse(command[2]));
                        }
                        else if (command[0].ToLower() == "refuel")
                        {
                            (car as Car).Refuel(double.Parse(command[2]));
                        }
                        break;
                    case "truck":
                        if (command[0].ToLower() == "drive")
                        {
                            (truck as Truck).Drive(double.Parse(command[2]));
                        }
                        else if (command[0].ToLower() == "refuel")
                        {
                            (truck as Truck).Refuel(double.Parse(command[2]));
                        }
                        break;
                    case "bus":
                        if (command[0].ToLower() == "drive")
                        {
                            (bus as Bus).Drive(double.Parse(command[2]));
                        }
                        else if (command[0].ToLower() == "driveempty")
                        {
                            (bus as Bus).DriveEmpty(double.Parse(command[2]));
                        }
                        else if (command[0].ToLower() == "refuel")
                        {
                            (bus as Bus).Refuel(double.Parse(command[2]));
                        }
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine((car as Car).ToString());
            Console.WriteLine((truck as Truck).ToString());
            Console.WriteLine((bus as Bus).ToString());
        }
    }
}
