using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Commando : SpecialisedSoldier, ICommando

    {
        public Commando(string firstName, string lastName, string id, decimal salary, string corps)
                   : base(firstName, lastName, id, salary, corps)
        {
            MissionsList = new List<Mission>();
        }
        public List<Mission> MissionsList { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Missions:");
            foreach (var item in MissionsList)
            {
                sb.AppendLine(" " + item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
