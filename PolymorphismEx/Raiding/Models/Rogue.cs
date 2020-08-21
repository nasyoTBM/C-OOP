using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name)
           : base(name)
        {
                
        }
        private const int ROGUE_POWER = 80;
        public override int Power => ROGUE_POWER;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
