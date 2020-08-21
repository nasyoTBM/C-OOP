using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Meat : Food, IFood
    {
        public Meat(int quantity)
            : base(quantity)
        {

        }
        
    }
}
