

using CarRental.Common.Enum;
using CarRental.Common.Interface;

namespace CarRental.Common.Classes
{
    public class Motorcycle : IVehicle
    {
        public string regNr { get; init; }
        public string brand { get; init; }
        public double odometer { get; init; }
        public double costKM { get; init; }
        public VehicleType Type { get; init; }
        public int costDay { get; init; }
        public VehicleStatus Status { get; init; }

        public Motorcycle(string nRegnr, string nBrand, double nOdometer, double nCostKM, VehicleType type, int nCostDay, VehicleStatus status) =>
        (regNr, brand, odometer, costKM, Type, costDay, Status) = (nRegnr, nBrand, nOdometer, nCostKM, type, costDay, status);
    }
}
