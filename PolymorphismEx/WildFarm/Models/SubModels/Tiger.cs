using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Tiger : Feline, IFeline
    {
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
        public override void IncreaseWeight()
        {
            double addOn = this.FoodEaten * 1;
            this.Weight += addOn;
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name.ToLower() != "meat")
            {
                WontEat(food);
            }
            else
            {
                FoodEaten += food.Quantity;
                IncreaseWeight();
            }
        }
    }
}
