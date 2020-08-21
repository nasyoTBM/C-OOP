using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission : IMission
    {
        public Mission(string codeName, string missionState)
        {
            CodeName = codeName;
            MissionState = missionState;
        }
        public string CodeName { get; set; }

        private MissionState missionState;

        public string MissionState
        {
            get { return missionState.ToString(); }
            set
            {
                MissionState state;
                if (!Enum.TryParse<MissionState>(value, out state))
                {
                    throw new ArgumentException("Invalid mission state!");
                }
                this.missionState = state;
            }
        }
        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {MissionState}";
        }


    }
}
