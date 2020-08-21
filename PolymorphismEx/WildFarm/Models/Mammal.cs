using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public abstract class Mammal : Animal, IMammal
    {
        public Mammal(string name,double weight,string livingRegion)
            :base(name,weight)
        {
            LivingRegion = livingRegion;
        }
        public string LivingRegion { get; protected set; }
        public override string ToString()
        {
            return $"{base.ToString()}{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
