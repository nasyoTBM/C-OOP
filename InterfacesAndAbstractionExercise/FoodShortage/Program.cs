using BorderControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> eaters = new List<IBuyer>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input.Length == 4)
                {
                    Citizen citizen = new Citizen(input[0], input[1], input[2], input[3]);
                    eaters.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    Rebel rebel = new Rebel(input[0], input[1], input[2]);
                    eaters.Add(rebel);
                }
            }
            string command = Console.ReadLine();
            while (command.ToLower()!="end")
            {
                var eater = eaters.FirstOrDefault(x => x.Name == command);
                if (eater != null)
                {
                    eater.BuyFood();
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(eaters.Sum(s=>s.Food));
        }
    }
}
