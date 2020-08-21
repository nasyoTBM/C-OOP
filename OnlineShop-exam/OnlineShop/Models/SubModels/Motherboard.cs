namespace OnlineShop.Models.SubModels
{
    public class Motherboard : Component
    {
        public const double OVERALLPERFORMANCEMULTIPLIER = 1.25;

        public Motherboard(int id, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
            : base(id, manufacturer, model, price, overallPerformance, generation)
        {
            
        }

        public override double OverallPerformance => base.OverallPerformance * OVERALLPERFORMANCEMULTIPLIER;
    }
}

