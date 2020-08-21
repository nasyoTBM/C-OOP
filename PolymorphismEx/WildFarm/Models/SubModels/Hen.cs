using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Hen : Bird, IBird
    {
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
        public override void IncreaseWeight()
        {
            double addOn = this.FoodEaten * 0.35;
            this.Weight += addOn;

        }
        public override void Eat(Food food)
        {
            
                FoodEaten += food.Quantity;
                IncreaseWeight();
            
        }
    }
}
