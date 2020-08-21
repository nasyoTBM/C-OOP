using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;

namespace OnlineShop.Models
{
    public abstract class Component : Product,IComponent
    {
        public Component(int id, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        :base(id,manufacturer,model,price,overallPerformance)
        {
            Generation = generation;
        }

        public int Generation { get; private set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
                .Append(string.Format(SuccessMessages.ComponentToString,Generation));
            return sb.ToString().TrimEnd();

        }
    }
}
