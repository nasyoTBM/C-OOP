using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Vegetable :Food, IFood
    {
        public Vegetable(int quantity)
            :base(quantity)
        {
            
        }
        
    }
}
