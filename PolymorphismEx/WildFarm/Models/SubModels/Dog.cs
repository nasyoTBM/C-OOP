using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Dog : Mammal, IMammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void IncreaseWeight()
        {
            double addOn = this.FoodEaten * 0.4;
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
