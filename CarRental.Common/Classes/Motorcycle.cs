

using CarRental.Common.Enum;
using CarRental.Common.Interface;

namespace CarRental.Common.Classes
{
    public class Motorcycle : IVehicle
    {
        public string RegNr { get; init; }
        public string Brand { get; init; }
        public double Odometer { get; init; }
        public double CostKM { get; init; }
        public VehicleType Type { get; init; }
        public int CostDay { get; init; }
        public double? RentedKM { get; init; }
        public DateTime? Rented { get; init; }
        public VehicleStatus Status { get; init; }
        public Motorcycle(string regNr, string brand, double odometer, double costKM, VehicleType type, int costDay, double? rentedKM, DateTime? rented, VehicleStatus status) => (RegNr, Brand, Odometer, CostKM, Type, CostDay, RentedKM, Rented, Status) = (regNr, brand, odometer, costKM, type, costDay, rentedKM, rented, status);
    }
}
