using CarRental.Common.Classes;
using CarRental.Common.Enum;
using CarRental.Common.Interface;
using CarRental.Data.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Data.Classes;

public class CollectionBase : IData
{
    readonly List<ICustomer> _customer = new List<ICustomer>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _booking = new List<IBooking>();

    public CollectionBase() => SeedData();

    void SeedData() 
    {
        // DatesTest
        DateTime rentDateOne = new DateTime(2023, 9, 10);
        DateTime rentDateTwo = new DateTime(2023, 9, 12);

        //Customer
        _customer.Add(new Customer(6407070001, "Johan", "Lager"));
        _customer.Add(new Customer(9902020002, "Rikard", "Ipa"));
        //Vehicles
        _vehicles.Add(new Car("ABC123", "Volvo", 10500, 2, VehicleType.Sedan, 100, 500, rentDateOne, VehicleStatus.Available));
        _vehicles.Add(new Car("DEF456", "BMW", 2000, 1.5, VehicleType.Sedan, 200, 800, rentDateTwo, VehicleStatus.Booked));
        _vehicles.Add(new Car("GHI789", "Suzuki", 20000, 2, VehicleType.Motorcycle, 300, null, null, VehicleStatus.Available));
        _vehicles.Add(new Car("JKL012", "Yamaha", 300, 3, VehicleType.Motorcycle, 400, null, null, VehicleStatus.Available));

        //Booking
        _booking.Add(new Booking(_vehicles.First(v => v.RegNr == "ABC123"), _customer.First(c => c.sSD == 6407070001), 500));
        _booking.Add(new Booking(_vehicles.First(v => v.RegNr == "DEF456"), _customer.First(c => c.sSD == 9902020002), null));
    }

  
    public IEnumerable<ICustomer> GetCustomers() => _customer;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = VehicleStatus.Booked) => _vehicles;
    public IEnumerable<IBooking> GetBookings() => _booking;
}
