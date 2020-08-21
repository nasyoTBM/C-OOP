using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WildFarm.Models.AnimalFactory.Model;
using WildFarm.Models.Engine.Contracts;


namespace WildFarm.Models.Engine
{
    public class Engine : IEngine
    {
        public Engine()
        {
            factory = new AnimalFactory.Model.AnimalFactory();
        }
        private readonly WildFarm.Models.AnimalFactory.Model.AnimalFactory factory;

        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            
            string input = Console.ReadLine();

            while (input.ToLower()!="end")
            {
                Animal animal = null;
                Food food = null;
                string[] inputAnimal = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string[] inputFood = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (inputFood.Length == 1 && inputFood[0].ToLower() == "end")
                {
                    break;
                }
                animal = factory.ProduceAnimal(inputAnimal);
                food = factory.ProduceFood(inputFood);
                if (animal!=null)
                {
                    animal.ProduceSound();
                    
                    if (food!=null)
                    {
                        animal.Eat(food);
                    }

                    animals.Add(animal);
                }

                


                input = Console.ReadLine();
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            

        }

    }
}
