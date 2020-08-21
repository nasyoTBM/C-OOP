using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Owl : Bird,IBird
    {
        public Owl(string name, double weight,double wingSize)
            :base(name,weight,wingSize)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
        public override void IncreaseWeight()
        {
            double addOn = this.FoodEaten * 0.25;
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
