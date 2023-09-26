

using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle vehicle { get; init; }
    public ICustomer customer { get; init; }
    public int kmReturned { get; init; }
    public DateTime? Rented { get; init; }
    public DateTime? Returned { get; init; }
    public double? totalCost { get; }

    public Booking(IVehicle Vehicle, ICustomer Customer, int nKmReturned, DateTime rented, DateTime returned, double nTotalCost) =>
        (vehicle, customer, kmReturned, Rented, Returned, totalCost) = (Vehicle, Customer, nKmReturned, rented, returned, nTotalCost);
}
