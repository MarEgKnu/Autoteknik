// See https://aka.ms/new-console-template for more information
// opretter instanser af Car og udskriver
using Autoteknik;

Owner owner1 = new Owner("Karl Johannson", "61615151", "hr");

ICar car1 = new Car("AE12312", 2009, "Toyota", "Toyota 2009", 20, owner1);

ICar car2 = new Car("AX12312", 2013, "Ford", "Chevy 2013", 20, owner1);

Console.WriteLine(car1);
Console.WriteLine(car2);

// opret CarCatalog instans og udskriv

ICarCatalog catalog = new CarCatalog("John Sharp", 249156);

catalog.AddCar(car1);
catalog.AddCar(car2);

Console.WriteLine(catalog);

// opret AutoRepair instans og udskriv

AutoRepair autorep1 = new AutoRepair("Motoroljie skiftet", 500.0);

AutoRepair autorep2 = new AutoRepair("Bremser på højre side skiftet", 600.0);

Console.WriteLine(autorep1);
Console.WriteLine(autorep2);

// tilføjer AutoRepairs til car1

car1.AddAutoRepair(autorep1);

car1.AddAutoRepair(autorep2);

Console.WriteLine(car1);

Console.WriteLine(catalog);

// tilføjer autorepair vha AddRepairToCar og udskriv

catalog.AddRepairToCar("AX12312", new AutoRepair("Nye dæk", 700));

Console.WriteLine(catalog);

// test TotalAutoRepairCost for car1, forventet resultat: 1100

Console.WriteLine(car1.TotalAutoRepairCost());

// test af argumentexception, hvis regnNr ikke er 7 karakterer
try
{
    ICar car3 = new Car("21345", 2009, "Ford", "Chevy 2009", 10, owner1);
}
catch(BadRegNrException e)
{
    Console.WriteLine(e.Message);
}

// test af AllCarsRepairCost, forventet resultat af alle reperationer: 1800

Console.WriteLine(catalog.AllCarsRepairCost());