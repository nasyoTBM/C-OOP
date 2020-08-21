using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    interface IEngineer : ISpecialisedSoldier
    {
        public List<Repair> RepairsList { get;}
    }
}
