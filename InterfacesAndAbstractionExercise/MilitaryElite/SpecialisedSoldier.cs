using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier :Private , ISpecialisedSoldier
    {
        

        public SpecialisedSoldier(string firstName, string lastName, string id, decimal salary, string corps)
            :base(firstName,lastName,id,salary)
        {
            Corps = corps;
        }
        private Corps corps;
        public string Corps 
        {
            get
            {
                return this.corps.ToString();
            }
            set
            {
                Corps corps;
                if (!Enum.TryParse<Corps>(value,out corps))
                {
                    throw new ArgumentException("Invalid corps");
                }
                this.corps = corps;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Corps: {corps}");
            return sb.ToString().TrimEnd();
        }
    }
}
