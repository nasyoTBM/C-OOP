﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<Mission> MissionsList { get;  }
    }
}
