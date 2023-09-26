

namespace CarRental.Common.Interface;

public interface IBooking
{
    IVehicle vehicle { get; }
    ICustomer customer { get; }
    public int kmReturned { get; init; }
    public DateTime? Rented { get; init; }
    public DateTime? Returned { get; init; }
    public double? totalCost { get; }


}
