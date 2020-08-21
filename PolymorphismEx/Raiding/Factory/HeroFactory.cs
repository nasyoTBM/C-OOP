using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Factory
{
    public class HeroFactory : IHeroFactory
    {
        public BaseHero CreateHero()
        {
            string name = Console.ReadLine();
            string type = Console.ReadLine();

            BaseHero hero = null;
            if (type.ToLower() == "paladin")
            {
                hero = new Paladin(name);
                
            }
            else if (type.ToLower() == "druid")
            {
                hero = new Druid(name);
                
            }
            else if (type.ToLower() == "warrior")
            {
                hero = new Warrior(name);
                
            }
            else if (type.ToLower() == "rogue")
            {
                hero = new Rogue(name);
                
            }
            else
            {
                Console.WriteLine("Invalid hero!");

            }

            return hero;
        }
    }
}
