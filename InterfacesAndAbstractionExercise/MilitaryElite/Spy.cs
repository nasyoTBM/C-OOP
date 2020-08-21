using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    class Spy : Soldier, ISpy
    {
        public Spy(string firstName,string lastName,string id,int codeNumber)
            :base(firstName,lastName,id)
        {
            CodeNumber = codeNumber;
        }
        public int CodeNumber { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Code Number: {CodeNumber}");
            return sb.ToString().TrimEnd();
        }
    }
}
