using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public abstract class Bird : Animal, IBird
    {
        public Bird(string name, double weight,double wingSize)
            :base(name,weight)
        {
            WingSize = wingSize;
        }
        public double WingSize { get; protected set; }

        public override string ToString()
        {
            return $"{base.ToString()}{WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
