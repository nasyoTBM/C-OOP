﻿namespace OnlineShop.Models.SubComputers
{
    class Laptop : Computer
    {
        private const double OVERALLPERFORMANCE = 10;

        public Laptop(int id, string manufacturer, string model, decimal price)
            : base(id, manufacturer, model, price, OVERALLPERFORMANCE)
        {
            
        }
        
    }
}
