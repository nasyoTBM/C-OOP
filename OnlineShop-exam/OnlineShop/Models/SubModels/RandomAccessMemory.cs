﻿namespace OnlineShop.Models.SubModels
{
    public class RandomAccessMemory : Component
    {
        private const double OVERALLPERFORMANCEMULTIPLIER = 1.20;
        public RandomAccessMemory(int id, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            
        }
        public override double OverallPerformance
        {
            get => base.OverallPerformance * OVERALLPERFORMANCEMULTIPLIER;
        }
    }
}
