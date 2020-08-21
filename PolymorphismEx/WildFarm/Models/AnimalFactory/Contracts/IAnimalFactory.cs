using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.AnimalFactory.Contracts
{
    public interface IAnimalFactory
    {
        public Animal ProduceAnimal(string[] args);
        public Food ProduceFood(string[] args);
        
    }
}
