using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name)
            :base(name)
        {

        }
        private const int DRUID_POWER = 80;
        public override int Power => DRUID_POWER;
        public override string CastAbility()
        {
            return $"{this.GetType().Name} - {Name} healed for {Power}";
        }
    }
}
