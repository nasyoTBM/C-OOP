using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public string Group { get; set; }
        private int food;
        public Rebel(string name, string age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public int Food { get => food; set => food = value; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
