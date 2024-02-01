
namespace Autoteknik
{
    public interface ICar
    {
        Dictionary<int, AutoRepair> AutoRepairs { get; }
        string Make { get; set; }
        int Mileage { get; set; }
        string Model { get; set; }
        Owner Owner { get; set; }
        string RegNr { get; set; }
        int Year { get; set; }

        bool AddAutoRepair(AutoRepair repair);
        string ToString();
        double TotalAutoRepairCost();
    }
}