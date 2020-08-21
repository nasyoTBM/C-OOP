using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.AnimalFactory.Contracts;
using WildFarm.Models.SubModels;

namespace WildFarm.Models.AnimalFactory.Model
{
    public class AnimalFactory : IAnimalFactory
    {
        public AnimalFactory()
        {

        }

        public Animal ProduceAnimal(string[] args)
        {
            Animal animal = null;
            switch (args[0].ToLower())
            {
                case "cat":
                    animal = new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
                    break;
                case "tiger":
                    animal = new Tiger(args[1], double.Parse(args[2]), args[3], args[4]);
                    break;
                case "owl":
                    animal = new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
                    break;
                case "hen":
                    animal = new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
                    break;
                case "mouse":
                    animal = new Mouse(args[1], double.Parse(args[2]),args[3]);
                    break;
                case "dog":
                    animal = new Dog(args[1], double.Parse(args[2]), args[3]);
                    break;
                default:
                    throw new ArgumentException("Invalid input for animal!");
                    
            }
            return animal;
        }
        public Food ProduceFood(string[] args)
        {
            Food food = null;
            switch (args[0].ToLower())
            {
                case "vegetable":
                    food = new Vegetable(int.Parse(args[1]));
                    break;
                case "fruit":
                    food = new Fruit(int.Parse(args[1]));
                    break;
                case "meat":
                    food = new Meat(int.Parse(args[1]));
                    break;
                case "seeds":
                    food = new Seeds(int.Parse(args[1]));
                    break;

                default:
                    throw new ArgumentException("Invalid input for food!");
            }
            return food;
        }
        
        
        
    }
}
