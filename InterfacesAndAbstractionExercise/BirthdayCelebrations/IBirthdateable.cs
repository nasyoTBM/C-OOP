using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    interface IBirthdateable
    {
        public string Name { get; }
        public string Birthdate { get;  }
        public bool LyckyBirthday(string input);
        
    }
}
