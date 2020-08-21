using System;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] truckInfo = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (input[1].ToLower())
                {
                    case "car":
                        if (input[0].ToLower() == "drive")
                        {
                            car.Drive(double.Parse(input[2]));
                        }
                        else if (input[0].ToLower() == "refuel")
                        {
                            car.Refuel(double.Parse(input[2]));
                        }
                        break;
                    case "truck":
                        if (input[0].ToLower() == "drive")
                        {
                            truck.Drive(double.Parse(input[2]));
                        }
                        else if (input[0].ToLower() == "refuel")
                        {
                            truck.Refuel(double.Parse(input[2]));
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());



        }
    }
}
