using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen : IIdentifiable
    {
        public Citizen(string name, string age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        private string name;
        private string age;
        private string id;
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
        public bool EndsWith(string input)
        {
            return Id.EndsWith(input);
        }
     
    }
}
