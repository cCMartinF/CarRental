using CarRental.Common.Enum;

namespace CarRental.Common.Interface;
public interface IVehicle
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
}
