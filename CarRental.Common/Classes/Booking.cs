

using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle vehicle { get; init; }
    public ICustomer customer { get; init; }
    public int kmReturned { get; init; }
    public DateTime? Rented { get; init; }
    public DateTime? Returned { get; init; }
 

    //    public Booking(IVehicle Vehicle, ICustomer Customer, int nKmReturned, DateTime rented) =>
    //    (vehicle, customer, kmReturned, Rented) = (Vehicle, Customer, nKmReturned, rented);
    //}
    public Booking(IVehicle Vehicle, ICustomer Customer, int nKmReturned, DateTime rented, DateTime returned) =>
    (vehicle, customer, kmReturned, Rented, Returned) = (Vehicle, Customer, nKmReturned, rented, returned);
}
