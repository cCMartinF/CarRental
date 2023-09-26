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
        var rentDateOne = new DateTime(2023, 9, 10);
        var rentDateTwo = new DateTime(2023, 9, 12); 
        var returnedDate = new DateTime(2023, 9, 25);

        _customer.Add(new Customer(6407070001, "Johan", "Lager"));
        _customer.Add(new Customer(9902020002, "Rikard", "Ipa"));
        _vehicles.Add(new Car("ABC123", "Volvo", 10500, 2, VehicleType.Sedan, 100, VehicleStatus.Available));
        _vehicles.Add(new Car("DEF456", "BMW", 2000, 1.5, VehicleType.Sedan, 200, VehicleStatus.Booked));
        _vehicles.Add(new Car("GHI789", "Suzuki", 20000, 2, VehicleType.Motorcycle, 300, VehicleStatus.Available));
        _vehicles.Add(new Car("JKL012", "Yamaha", 300, 3, VehicleType.Motorcycle, 400, VehicleStatus.Booked));
        var test = _vehicles.First(v => v.regNr == "DEF456");
        var testTwo = _customer.First(v => v.sSD == 6407070001);

        //_booking.Add(new Booking(test, testTwo, 100, rentDateTwo, null ))

        //var carRentedOne = _vehicles.First();
        //var carRentedTwo = _vehicles.
        //_booking.Add(new Booking(IVehicle(Car()), _customer, 500, rentDateOne, returnedDate )
    }

    //IEnumerable<string> names = from person in people
    //                            where person.Pets.All(pet => pet.Age > 5)
    //                            select person.LastName;
    
    public IEnumerable<ICustomer> GetCustomers() => _customer;
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = VehicleStatus.Booked) => _vehicles;
    public IEnumerable<IBooking> GetBookings() => _booking;
}
