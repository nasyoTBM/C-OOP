namespace OnlineShop.Models.SubComputers
{
    public class DesktopComputer : Computer
    {
        public const double OVERALLPERFORMANCE = 15;

        public DesktopComputer(int id, string manufacturer, string model, decimal price)
            : base(id, manufacturer, model, price,OVERALLPERFORMANCE)
        {
            
        }
        


    }
}
