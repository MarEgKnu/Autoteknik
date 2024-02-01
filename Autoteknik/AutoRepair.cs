using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik
{
    public class AutoRepair
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public Mechanic? Mechanic { get; set; }

        public bool Done { get; set; }

        public string MechanicComment { get; set; }

        private static int _counter = 0;
        public AutoRepair(string description, double price)
        {
            _counter++;
            Id = _counter;
            DateTime = DateTime.Now;
            Description = description;
            Price = price;
            Mechanic = null;
            MechanicComment = "";
            Done = false;

        }
        public void AddMechanic(Mechanic mechanic)
        {
            Mechanic = mechanic;
            return;
        }
        public void FinishRepair(string mechanicComment)
        {
            if (Done)
            {
                return;
            }
            else
            {
                Done = true;
                MechanicComment = mechanicComment;
                return;
            }
        }
        public override string ToString()
        {
            return $"ID: {Id}, Time of creaton: {DateTime}, Description: {Description}, Price: {Price}";
        }
    }
}
