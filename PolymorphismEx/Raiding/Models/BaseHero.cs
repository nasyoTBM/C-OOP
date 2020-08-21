using Raiding.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Raiding;

namespace Raiding.Models
{
    public class BaseHero : IBaseHero
    {
        public BaseHero(string name)
        {
            Name = name;
        }
        private string name;
        public string Name 
        { 
            get => name; 
            set 
            { 
                name = value;
            }
        }
        private int power;

        public virtual int Power
        {
            get { return power; }
            private set { power = value; }
        }

        public virtual string CastAbility()
        {
            return null;
        }

       
    }
}
