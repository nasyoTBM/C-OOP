using BorderControl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<IBirthdateable> targetsList = new List<IBirthdateable>();
            while (command.ToLower()!="end")
            {
                string[] input = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (input[0].ToLower())
                {
                    case "citizen" :
                        string name = input[1];
                        string age = input[2];
                        string id = input[3];
                        string birthdate = input[4];
                        Citizen citizen = new Citizen(name, age, id, birthdate);
                        targetsList.Add(citizen);
                        break;
                    case "pet":
                        string petName = input[1];
                        string petBirthdate = input[2];
                        Pet pet = new Pet(petName, petBirthdate);
                        targetsList.Add(pet);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            string luckyDate = Console.ReadLine();
            foreach (var target in targetsList)
            {
                if (target.LyckyBirthday(luckyDate))
                {
                    Console.WriteLine(target.Birthdate);
                }
            }
        }
    }
}
