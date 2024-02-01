using Microsoft.VisualStudio.TestTools.UnitTesting;
using Autoteknik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoteknik.Tests
{
    [TestClass()]
    public class CarCatalogTests
    {
        public ICarCatalog catalog { get; set; }
        public ICar c1 { get; set; }
        public ICar c2 { get; set; }

        public ICar c3 { get; set; }

        public AutoRepair autoRepair1 { get; set; }
        public AutoRepair autoRepair2 { get; set; }
        public AutoRepair autoRepair3 { get; set; }

        [TestMethod()]
        public void AddCarTest()
        {
            SetUp();          
            catalog.AddCar(c1);
            int beforeAmount = catalog.GetAllCars().Count();
            catalog.AddCar(c2);
            int afterAmount = catalog.GetAllCars().Count();
            Assert.AreEqual(beforeAmount+1, afterAmount);
        }

        [TestMethod()]
        public void AddRepairToCarTest()
        {
            SetUp();
            string regNr = "4313456";
            catalog.AddCar(c1);
            int count = 3;
            catalog.AddRepairToCar(regNr, autoRepair1);
            catalog.AddRepairToCar(regNr, autoRepair2);
            catalog.AddRepairToCar(regNr, autoRepair3);
            Assert.AreEqual(count, catalog.GetCar(regNr).AutoRepairs.Count());
        }

        [TestMethod()]
        public void AllCarsRepairCostTest()
        {
            SetUp();
            catalog.AddCar(c1);
            catalog.AddCar(c2);
            catalog.AddRepairToCar("4313456", autoRepair1);
            catalog.AddRepairToCar("4313456", autoRepair2);
            catalog.AddRepairToCar("4313457", autoRepair3);
            double expectedResult = autoRepair1.Price + autoRepair2.Price + autoRepair3.Price;
            Assert.AreEqual(expectedResult, catalog.AllCarsRepairCost());
        }
        public void SetUp()
        {
            catalog = new CarCatalog("Test Name", 234111);
            c1 = new Car("4313456", 1991, "Toyota", "Chevy", 19, new Owner("Jens Hansen", "191919", "Hr"));
            c2 = new Car("4313457", 1991, "Toyota", "Chevy", 19, new Owner("Jens Hansen", "191919", "Hr"));
            c3 = new Car("4313457", 1991, "Toyota", "Chevy", 19, new Owner("Jens Hansen", "191919", "Hr"));
            autoRepair1 = new AutoRepair("Ny Motor", 2500);
            autoRepair2 = new AutoRepair("Flade dæk", 600);
            autoRepair3 = new AutoRepair("Oijeskift", 750);
            return;
        }
    }
}