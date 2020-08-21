using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models
{
    public abstract class Peripheral : Product , IPeripheral
    {
        public Peripheral(int id, string manufacturer, string model, decimal price,
            double overallPerformance,string connectionType)
        :base(id,manufacturer,model,price,overallPerformance)
        {
            ConnectionType = connectionType;
        }
        public string ConnectionType { get; private set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
                .Append(string.Format(SuccessMessages.PeripheralToString, ConnectionType));
            return sb.ToString().TrimEnd();
        }
    }
}
