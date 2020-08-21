using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models
{
    public abstract class Animal : IAnimal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }
        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get; set; }

        public virtual void ProduceSound()
        {
            
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, ";
        }
        public virtual void IncreaseWeight()
        {

        }
        public virtual void Eat(Food food)
        {

        }
        public void WontEat(Food food)
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }


    }
}
