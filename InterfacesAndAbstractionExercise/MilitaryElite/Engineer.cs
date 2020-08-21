using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string firstName, string lastName, string id, decimal salary, string corps )
            : base(firstName, lastName, id, salary, corps)
        {
            RepairsList = new List<Repair>();
        }
        public List<Repair> RepairsList { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Repairs:");
            foreach (var item in RepairsList)
            {
                sb.AppendLine(" " + item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
