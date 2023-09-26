

using CarRental.Common.Enum;
using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Car : IVehicle
{
    public string regNr { get; init; }
    public string brand { get; init; }
    public double odometer { get; init; }
    public double costKM { get; init; }
    public VehicleType type { get; init; }
    public int costDay { get; init; }
    public VehicleStatus status { get; init; }
}
