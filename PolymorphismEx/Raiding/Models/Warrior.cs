using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Warrior : BaseHero
    {
        public Warrior(string name)
           : base(name)
        {

        }
        private const int WARRIOR_POWER = 100;
        public override int Power => WARRIOR_POWER;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
