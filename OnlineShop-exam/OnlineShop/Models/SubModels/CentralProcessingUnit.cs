namespace OnlineShop.Models.SubModels
{
    public class CentralProcessingUnit : Component
    {
        private const double OVERALLPERFORMANCEMULTIPLIER = 1.25;
        public CentralProcessingUnit(int id, string manufacturer, string model, decimal price,
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
