using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Models.Contracts;

namespace WildFarm.Models.SubModels
{
    public class Seeds : Food, IFood
    {
        public Seeds(int quantity)
            : base(quantity)
        {

        }
        
    }
}
