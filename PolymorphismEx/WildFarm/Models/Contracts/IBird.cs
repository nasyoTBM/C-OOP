using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Models.Contracts
{
    interface IBird : IAnimal
    {
        public double WingSize { get; }
    }
}
