using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        private string model;
        private string color;
        private int battery;
        public string Model { get => model; private set { model = value; } }

        public string Color { get => color;private set  => color = value;  }

        public int Battery { get => battery;private set { battery = value; } }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries")
                .AppendLine($"{Start()}")
                .AppendLine($"{Stop()}");
            return sb.ToString().TrimEnd();
        }
    }
}
