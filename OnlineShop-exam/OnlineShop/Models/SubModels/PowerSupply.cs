namespace OnlineShop.Models.SubModels
{
    public class PowerSupply : Component
    {
        public const double OVERALLPERFORMANCEMULTIPLIER = 1.05;
        public PowerSupply(int id, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            
        }
        public override double OverallPerformance => base.OverallPerformance * OVERALLPERFORMANCEMULTIPLIER;
    }
}
