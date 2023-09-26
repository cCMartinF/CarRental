using CarRental.Common.Enum;

namespace CarRental.Common.Interface;
public interface IVehicle
{
    public string regNr { get; init; }
    public string brand { get; init; }
    public double odometer { get; init; }
    public double costKM { get; init; }
    public VehicleType Type { get; init; }
    public int costDay { get; init; }
    public VehicleStatus Status { get; init; }
}
