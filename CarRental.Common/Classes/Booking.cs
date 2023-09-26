

using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle vehicle { get; }
    public ICustomer customer { get; }
    public int kmReturned { get; init; }
    public DateTime? Rented { get; init; }
    public DateTime? Returned { get; init; }
    public double? totalCost { get; }
    
}
