using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class CarCatalog : ICarCatalog
    {
        public string Name { get; set; }

        public int Cvr { get; set; }

        private List<ICar> _cars { get; set; }

        public CarCatalog(string name, int cvr)
        {
            _cars = new List<ICar>();
            Name = name;
            Cvr = cvr;
        }

        public bool AddCar(ICar car)
        {
            foreach (var item in _cars)
            {
                if (item.RegNr == car.RegNr)
                {
                    return false;
                }
            }
            _cars.Add(car);
            return true;
        }
        public void AddRepairToCar(string regNr, AutoRepair newAutoRepair)
        {
            foreach (var item in _cars)
            {
                if (item.RegNr == regNr)
                {
                    item.AddAutoRepair(newAutoRepair);
                }
            }
        }
        public double AllCarsRepairCost()
        {
            double sum = 0;
            foreach (var item in _cars)
            {
                sum = sum + item.TotalAutoRepairCost();
            }
            return sum;
        }
        public override string ToString()
        {
            string mainString = $"Owner Name: {Name}, CVR: {Cvr}\nVehicles:\n\t";
            string carString = string.Join("\n\t", _cars);
            return mainString + carString;
        }

        public List<ICar> GetAllCars()
        {
            return _cars;
        }

        public ICar? GetCar(string regNr)
        {
            foreach(var item in _cars)
            {
                if (regNr == item.RegNr)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
