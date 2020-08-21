using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        public Paladin(string name)
           :base(name)
        {

        }
        private const int PALADIN_POWER = 100;
        public override int Power => PALADIN_POWER;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
