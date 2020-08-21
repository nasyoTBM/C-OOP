using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> data = new List<Soldier>();
            string command = Console.ReadLine();
            while (command.ToLower()!="end")
            {
                string[] input = command
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                switch (input[0])
                {
                    case "Private":
                        Private priv = new Private(input[2], input[3], input[1], decimal.Parse(input[4]));
                        data.Add(priv);
                        break;
                    case "LieutenantGeneral":
                        LieutenantGeneral gen = new LieutenantGeneral(input[2], input[3], input[1], decimal.Parse(input[4]));
                        for (int i = 5; i < input.Length; i++)
                        {
                            Private privat = (Private)data.First(x => x.Id == input[i]);
                            gen.PrivatesList.Add(privat);
                            
                        }
                        data.Add(gen);
                        
                        break;
                    case "Engineer":
                        try
                        {
                            Engineer engineer = new Engineer(input[2], input[3], input[1], decimal.Parse(input[4]), input[5]);

                            for (int i = 6; i < input.Length; i += 2)
                            {
                                Repair repair = new Repair(input[i], int.Parse(input[i + 1]));
                                engineer.RepairsList.Add(repair);
                            }

                            data.Add(engineer);
                        }
                        catch (ArgumentException)
                        {

                        }

                        break;
                    case "Commando":
                        try
                        {
                            Commando commando = new Commando(input[2],input[3],input[1],decimal.Parse(input[4]),input[5]);

                            for (int i = 6; i < input.Length; i += 2)
                            {
                                try
                                {
                                    Mission mission = new Mission(input[i], input[i + 1]);
                                    commando.MissionsList.Add(mission);

                                }
                                catch (ArgumentException)
                                {

                                }
                            }

                            data.Add(commando);
                        }
                        catch (ArgumentException)
                        {

                        }
                        break;
                    case "Spy":
                        Spy spy = new Spy(input[2], input[3], input[1], int.Parse(input[4]));
                        data.Add(spy);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            data.ForEach(Console.WriteLine);


        }
        
    }
}
