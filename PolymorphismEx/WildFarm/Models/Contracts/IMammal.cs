﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Contracts
{
    public interface IMammal:IAnimal
    {
        public string LivingRegion { get;  }
    }
}
