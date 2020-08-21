using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
        private string model;
        private string id;
        public string Id { get => id; set { id = value; } }
        public string Model { get => model; set { model = value; } }

        public bool EndsWith(string input)
        {
            return Id.EndsWith(input);
        }
    }
}
