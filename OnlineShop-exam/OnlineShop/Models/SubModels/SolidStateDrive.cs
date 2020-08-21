﻿namespace OnlineShop.Models.SubModels
{
    public class SolidStateDrive : Component
    {
        public const double OVERALLPERFORMANCEMULTIPLIER = 1.20;
        public SolidStateDrive(int id, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            
        }
        public override double OverallPerformance => base.OverallPerformance * OVERALLPERFORMANCEMULTIPLIER;
    }
}
