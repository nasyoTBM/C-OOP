using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        
            
        public LieutenantGeneral(string firstName, string lastName, string id, decimal salary)
            :base(firstName,lastName,id,salary)
        {
            
            PrivatesList = new List<Private>();
        }
       
        public List<Private> PrivatesList { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var current in this.PrivatesList)
            {
                builder.AppendLine("  " + current.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
