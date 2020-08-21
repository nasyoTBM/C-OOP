using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Raiding.Engine.Contracts;
using Raiding.Factory;
using Raiding.Models;

namespace Raiding.Engine
{
    public class Engine : IEngine
    {
        public Engine()
        {

        }
        private readonly HeroFactory heroFactory = new HeroFactory();
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();
            int totalPower = 0;
            BaseHero hero = null;

            while (heroes.Count != n)
            {
                hero = heroFactory.CreateHero();
                if (hero != null)
                {
                    heroes.Add(hero);
                }


            }

            int bossPower = int.Parse(Console.ReadLine());
            foreach (var item in heroes)
            {
                Console.WriteLine(item.CastAbility());
            }
            totalPower = heroes.Sum(x => x.Power);
            if (totalPower < bossPower)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
            
        }
    }
}



