using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.Products.Peripherals;

namespace OnlineShop.Models
{
    public abstract class Computer : Product,IComputer
    {
        public Computer(int id, string manufacturer, string model, decimal price,
            double overallPerformance)
        :base(id,manufacturer,model,price,overallPerformance)
        {
            
            components = new List<IComponent>();
            peripherals = new List<IPeripheral>();
            


        }
        private readonly List<IComponent> components;
        private readonly List<IPeripheral> peripherals;
        
        
        public override double OverallPerformance
        {
            get
            {
                if (!Components.Any())
                {
                    return overallPerformance;
                }

                return overallPerformance + this.Components.Average(c => c.OverallPerformance);
            }
        }

        public override decimal Price
        {
            get
            {
                var compSum = Components.Any()
                    ? Components.Sum(c => c.Price)
                    : 0;

                var perphSum = Peripherals.Any()
                    ? Peripherals.Sum(p => p.Price)
                    : 0;

                return price + compSum + perphSum;
            }
        }

        public IReadOnlyCollection<IComponent> Components => components.AsReadOnly();
        

        public IReadOnlyCollection<IPeripheral> Peripherals => peripherals.AsReadOnly();
        
        public void AddComponent(IComponent component)
        {
            if (!ValidateTypeComponent(component.GetType().Name))
            {
               throw new ArgumentException(String.Format(ExceptionMessages.ExistingComponent,component.GetType().Name,this.GetType().Name,this.Id));
            }
           
                components.Add(component);
            
        }

        public IComponent RemoveComponent(string componentType)
        {
            
            if (components.Count==0 || ValidateTypeComponent(componentType))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingComponent,componentType,this.GetType().Name,this.Id));
            }
            IComponent component = components.FirstOrDefault(s=>s.GetType().Name == componentType);
            components.Remove(component);
            return component;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (!ValidateTypePeripheral(peripheral.GetType().Name))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.ExistingPeripheral,peripheral.GetType().Name,this.GetType().Name,this.Id));
            }
            peripherals.Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (peripherals.Count == 0 || ValidateTypePeripheral(peripheralType))
            {
                throw new ArgumentException(String.Format(ExceptionMessages.NotExistingPeripheral,peripheralType,this.GetType().Name,this.Id));
            }

            IPeripheral peripheral = peripherals.FirstOrDefault(s => s.GetType().Name == peripheralType);
            peripherals.Remove(peripheral);
            return peripheral;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .Append(" ")
                .AppendLine(string.Format(SuccessMessages.ComputerComponentsToString,Components.Count));
            if (components.Count!=0)
            {
                foreach (var c in Components)
                {
                    sb.AppendLine($"  {c}");
                }
            }

            sb.Append(" ");
            
            if (peripherals.Count!=0)
            {
                sb.AppendLine(string.Format(SuccessMessages.ComputerPeripheralsToString, Peripherals.Count, peripherals.Average(s => s.OverallPerformance)));
                foreach (var p in Peripherals)
                {
                    sb.AppendLine($"  {p}");
                }
            }
            else
            {
                sb.AppendLine(string.Format(SuccessMessages.ComputerPeripheralsToString, 0, 0));
            }
            
            return sb.ToString().TrimEnd();
        }
        public bool ValidateTypeComponent(string componentType)
        {
            bool result = true;
            foreach (var c in components)
            {
                string type = c.GetType().Name;
                if (type == componentType)
                {
                    result = false;
                }
            }

            return result;
        }
        public bool ValidateTypePeripheral(string peripheralType)
        {
            bool result = true;
            foreach (var c in peripherals)
            {
                string type = c.GetType().Name;
                if (type == peripheralType)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
