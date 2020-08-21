using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        private string model;
        private string color;
        
        public string Model { get => model; private set  => model = value;  }

        public string Color { get => color; private set { color = value; } }

        public string Start()
        {
             return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Seat {Model}")
                .AppendLine($"{Start()}")
                .AppendLine($"{Stop()}");
            return sb.ToString();
            
       
        }
    }
}
