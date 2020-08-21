using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : IBirthdateable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
        private string name;
        private string birthdate;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;

            }
        }

        public string Birthdate { get => birthdate; set => birthdate = value; }

        public bool LyckyBirthday(string input)
        {
            return Birthdate.EndsWith(input);
        }
    }
}
