using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IIdentifiable> targets = new List<IIdentifiable>();
            while (command.ToLower() != "end")
            {
                string[] input = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input.Length == 3)
                {
                    string name = input[0];
                    string age = input[1];
                    string id = input[2];
                    Citizen citizen = new Citizen(name, age, id);
                    targets.Add(citizen);
                }
                else if (input.Length == 2)
                {
                    string model = input[0];
                    string id = input[1];
                    Robot robot = new Robot(model,id);
                    targets.Add(robot);
                }

                command = Console.ReadLine();
            }
            string identifier = Console.ReadLine();
            foreach (var target in targets)
            {
                if (target.EndsWith(identifier))
                {
                    Console.WriteLine(target.Id);
                }
            }

        }
    }
}
