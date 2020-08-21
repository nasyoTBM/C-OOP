using System;
using OnlineShop.Models.Products;
using OnlineShop.Common.Constants;

namespace OnlineShop.Models
{
    public abstract class Product : IProduct
    {

        public Product(int id, string manufacturer, string model, decimal price,
            double overallPerformance)
        {
            Id = id;
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            OverallPerformance = overallPerformance;
        }

        private int id;
        private string manufacturer;
        private string model;
        protected decimal price;
        protected double overallPerformance;
        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidProductId);
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidManufacturer);
                }

                manufacturer = value;

            }

        }
        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidModel);
                }

                model = value;

            }

        }
        public virtual decimal Price
        {
            get
            {
                return price;
            }
            private set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPrice);
                }
            }
        }
        public virtual double OverallPerformance
        {
            get
            {
                return overallPerformance;
            }
            private set
            {
                if (value > 0)
                {
                    overallPerformance = value;
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidOverallPerformance);
                }
            }
        }

        public override string ToString()
        {
            //return $"Overall Performance: {OverallPerformance}. Price: {Price} - {this.GetType().Name}: {Manufacturer} {Model} (Id: {Id})";
            return string.Format(SuccessMessages.ProductToString, OverallPerformance, Price, this.GetType().Name, Manufacturer, Model, Id);

        }
    }
}
