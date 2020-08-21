using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public abstract class Feline : Animal, IFeline
    {
        public Feline(string name, double weight,string livingRegion, string breed)
            : base(name, weight)
        {
            LivingRegion = livingRegion;
            Breed = breed;
        }
        public string Breed { get; protected set; }

        public string LivingRegion { get; protected set; }
        public override string ToString()
        {
            return $"{base.ToString()}{Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
