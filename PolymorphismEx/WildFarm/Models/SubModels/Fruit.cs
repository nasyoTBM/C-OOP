using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Fruit : Food, IFood
    {
        public Fruit(int quantity)
            : base(quantity)
        {

        }
        
    }
}
