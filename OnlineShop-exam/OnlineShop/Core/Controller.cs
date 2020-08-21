using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models.Products.Computers;
using OnlineShop.Models.SubComputers;
using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Peripherals;
using OnlineShop.Models.SubModels;
using OnlineShop.Models.SubPeripheral;
using IComponent = OnlineShop.Models.Products.Components.IComponent;

namespace OnlineShop.Core
{
    public class Controller : IController
    {
        public Controller()
        {
            pcs = new List<IComputer>();
            cs = new List<IComponent>();
            ps = new List<IPeripheral>();
        }
        private readonly List<IComputer> pcs;
        private readonly List<IComponent> cs;
        private readonly List<IPeripheral> ps;
        public IReadOnlyCollection<IComputer> Pcs => pcs.AsReadOnly();
        public IReadOnlyCollection<IComponent> Cs => cs.AsReadOnly();
        public IReadOnlyCollection<IPeripheral> Ps => ps.AsReadOnly();
        public string AddComputer(string computerType, int id, string manufacturer, string model, decimal price)
        {
            if (!ValidateId(id))
            {
                throw new ArgumentException(ExceptionMessages.ExistingComputerId);
            }
            IComputer pc;
            if (computerType == "DesktopComputer")
            {
                pc = new DesktopComputer(id, manufacturer, model, price);
            }
            else if (computerType == "Laptop")
            {
                pc = new Laptop(id, manufacturer, model, price);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComputerType);
            }
            pcs.Add(pc);
            return string.Format(SuccessMessages.AddedComputer, pc.Id);


        }

        public string AddPeripheral(int computerId, int id, string peripheralType, string manufacturer, string model, decimal price,
            double overallPerformance, string connectionType)
        {
            IPeripheral peri;
            if (ValidateId(computerId))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
            switch (peripheralType)
            {
                case "Headset":
                    peri = new Headset(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                case "Keyboard":
                    peri = new Keyboard(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                case "Monitor":
                    peri = new Monitor(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                case "Mouse":
                    peri = new Mouse(id, manufacturer, model, price,
                        overallPerformance, connectionType);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidPeripheralType);
            }
            string result = string.Empty;
            IComputer pc = pcs.FirstOrDefault(s => s.Id == computerId);
            IPeripheral test = ps.FirstOrDefault(s => s.Id == peri.Id);
            if (test != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingPeripheralId));
            }
            if (pc.GetType().Name == "DesktopComputer")
            {
                pc = (DesktopComputer)pc;
                pc.AddPeripheral(peri);
                ps.Add(peri);
                result = string.Format(SuccessMessages.AddedPeripheral, peripheralType, id, computerId);
            }
            else if (pc.GetType().Name == "Laptop")
            {
                pc = (Laptop)pc;
                pc.AddPeripheral(peri);
                ps.Add(peri);
                result = string.Format(SuccessMessages.AddedComponent, peripheralType, id, computerId);
            }

            return result;

        }

        public string RemovePeripheral(string peripheralType, int computerId)
        {

            IComputer pc = pcs.FirstOrDefault(s => s.Id == computerId);
            if (pc != null)
            {
                IPeripheral peri = pc.Peripherals.FirstOrDefault(s => s.GetType().Name == peripheralType);

                pc.RemovePeripheral(peripheralType);
                ps.Remove(peri);
                return string.Format(SuccessMessages.RemovedPeripheral, peripheralType, peri.Id);

            }
            throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComputerId));


        }

        public string AddComponent(int computerId, int id, string componentType, string manufacturer, string model, decimal price,
            double overallPerformance, int generation)
        {
            IComponent component;
            if (ValidateId(computerId))
            {
                throw new ArgumentException(ExceptionMessages.NotExistingComputerId);
            }
            switch (componentType)
            {
                case "CentralProcessingUnit":
                    component = new CentralProcessingUnit(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "Motherboard":
                    component = new Motherboard(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "PowerSupply":
                    component = new PowerSupply(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "RandomAccessMemory":
                    component = new RandomAccessMemory(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "SolidStateDrive":
                    component = new SolidStateDrive(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                case "VideoCard":
                    component = new VideoCard(id, manufacturer, model, price, overallPerformance,
                        generation);
                    break;
                default:
                    throw new ArgumentException(ExceptionMessages.InvalidComponentType);
            }

            string result = string.Empty;
            IComputer pc = pcs.FirstOrDefault(s => s.Id == computerId);
            IComponent test = cs.FirstOrDefault(s => s.Id == component.Id);
            if (test != null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ExistingComponentId));
            }
            if (pc.GetType().Name == "DesktopComputer")
            {
                pc = (DesktopComputer)pc;
                pc.AddComponent(component);
                cs.Add(component);
                result = string.Format(SuccessMessages.AddedComponent, componentType, component.Id, pc.Id);
            }
            else if (pc.GetType().Name == "Laptop")
            {
                pc = (Laptop)pc;
                pc.AddComponent(component);
                cs.Add(component);
                result = string.Format(SuccessMessages.AddedComponent, componentType, component.Id, pc.Id);
            }

            return result;


        }

        public string RemoveComponent(string componentType, int computerId)
        {

            IComputer pc = pcs.FirstOrDefault(s => s.Id == computerId);

            if (pc != null)
            {
                IComponent component = pc.Components.FirstOrDefault(s => s.GetType().Name == componentType);
                pc.RemoveComponent(componentType);
                cs.Remove(component);
                return string.Format(SuccessMessages.RemovedComponent, componentType, component.Id);

            }
            throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComputerId));




        }

        public string BuyComputer(int id)
        {
            if (pcs.Count == 0)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.NotExistingComputerId));
            }

            if (!ValidateId(id))
            {
                IComputer pc = pcs.FirstOrDefault(s => s.Id == id);
                string result = GetComputerData(id);
                pcs.Remove(pc);
                return result;
            }

            throw new ArgumentException(ExceptionMessages.NotExistingComputerId);


        }

        public string BuyBest(decimal budget)
        {

            if (pcs.Count == 0)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }



            IComputer pcz = pcs.Where(s => s.Price <= budget)
                .OrderByDescending(s => s.OverallPerformance)
                .FirstOrDefault();
            if (pcz == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.CanNotBuyComputer, budget));
            }
            pcs.Remove(pcz);
            return pcz.ToString();

        }

        public string GetComputerData(int id)
        {
            IComputer pc = pcs.FirstOrDefault(s => s.Id == id);
            if (pc != null)
            {
                return pc.ToString();
            }
            throw new ArgumentException(ExceptionMessages.NotExistingComputerId);

        }

        private bool ValidateId(int id)
        {
            IComputer pc2;

            pc2 = pcs.FirstOrDefault(s => s.Id == id);
            if (pc2 == null)
            {
                return true;
            }

            return false;
        }
    }
}
