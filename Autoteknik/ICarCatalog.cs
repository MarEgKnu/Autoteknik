namespace Autoteknik
{
    public interface ICarCatalog
    {
        int Cvr { get; set; }
        string Name { get; set; }

        bool AddCar(ICar car);
        void AddRepairToCar(string regNr, AutoRepair newAutoRepair);
        double AllCarsRepairCost();
        List<ICar> GetAllCars();

        ICar? GetCar(string regNr);
        string ToString();
    }
}