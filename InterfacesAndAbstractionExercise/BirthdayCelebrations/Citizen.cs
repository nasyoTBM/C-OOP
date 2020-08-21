using BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable , IBirthdateable
    {
        public Citizen(string name, string age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        private string name;
        private string age;
        private string id;
        private string birthdate;
        public string Id 
        { 
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Age 
        { 
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
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

        public bool EndsWith(string input)
        {
            return Id.EndsWith(input);
        }

        public bool LyckyBirthday(string input)
        {
            return Birthdate.EndsWith(input);
        }
    }
}
