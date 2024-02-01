using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class Car : ICar
    {
        public string RegNr { get; set; }

        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Mileage { get; set; }

        public Owner Owner { get; set; }

        public Dictionary<int, AutoRepair> AutoRepairs { get; private set; }
        public Car(string regNr, int year, string make, string model, int mileage, Owner owner)
        {
            if (regNr.Length != 7)
            {
                throw new BadRegNrException("RegNr must be 7 characters");
            }
            RegNr = regNr;
            Year = year;
            Make = make;
            Model = model;
            Mileage = mileage;
            Owner = owner;
            AutoRepairs = new Dictionary<int, AutoRepair>();
        }

        public override string ToString()
        {
            string carString = $"RegNr: {RegNr}, Year: {Year}, Make: {Make}, Model: {Model}, Mileage: {Mileage}. Owner infomation: {Owner}";
            string repairString = "\n\tRepairs:\n\t\t" + string.Join("\n\t\t", AutoRepairs.Values);
            return carString + repairString;
        }
        public bool AddAutoRepair(AutoRepair repair)
        {
            if (!AutoRepairs.ContainsKey(repair.Id))
            {
                AutoRepairs.Add(repair.Id, repair);
                return true;
            }
            else
            {
                return false;
            }
        }
        public double TotalAutoRepairCost()
        {
            double sum = 0;
            foreach (AutoRepair repair in AutoRepairs.Values)
            {
                sum = sum + repair.Price;
            }
            return sum;
        }
    }
}
