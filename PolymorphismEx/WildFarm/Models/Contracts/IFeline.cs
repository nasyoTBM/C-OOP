using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Contracts
{
    public interface IFeline:IAnimal,IMammal
    {
        public string Breed { get; }
    }
}
