using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Mouse : Mammal,IMammal
    {
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight,livingRegion)
        {
            
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
        public override void IncreaseWeight()
        {
            double addOn = this.FoodEaten * 0.1;
            this.Weight += addOn;
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name.ToLower() != "vegetable" && food.GetType().Name.ToLower() != "fruit")
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
