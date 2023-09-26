using CarRental.Common.Classes;
using CarRental.Common.Enum;
using CarRental.Common.Interface;
using CarRental.Data.Interface;
using System.Collections.Generic;

namespace CarRental.Data.Classes;

public class CollectionBase : IData
{
    readonly List<ICustomer> _customer = new List<ICustomer>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _booking = new List<IBooking>();

    public CollectionBase() => SeedData();

    void SeedData() 
    {
        var rentDateOne = new DateTime(2023, 9, 10);
        var rentDateTwo = new DateTime(2023, 9, 12);
        var returnedDate = new DateTime(2023, 9, 25);

        _customer.Add(new Customer(6407070001, "Johan", "Lager"));
        _customer.Add(new Customer(9902020002, "Rikard", "Ipa"));
        _vehicles.Add(new Car("ABC123", "Volvo", 10500, 2, VehicleType.Sedan, 100, VehicleStatus.Available));
        _vehicles.Add(new Car("DEF456", "BMW", 2000, 1.5, VehicleType.Sedan, 200, VehicleStatus.Booked));
        _vehicles.Add(new Car("GHI789", "Suzuki", 20000, 2, VehicleType.Motorcycle, 300, VehicleStatus.Available));
        _vehicles.Add(new Car("JKL012", "Yamaha", 300, 3, VehicleType.Motorcycle, 400, VehicleStatus.Booked));
        //_booking.Add(new Booking(_vehicles, _customer, 500, rentDateOne, )
    }
    
    public IEnumerable<ICustomer> GetCustomers() => _customer;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default) => _vehicles;
    public IEnumerable<IBooking> GetBookings() => _booking;
}
