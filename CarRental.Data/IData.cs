

using CarRental.Common.Enum;
using CarRental.Common.Interface;

namespace CarRental.Data;

public interface IData
{
    IEnumerable<ICustomer> GetCustomers();
    IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default);
    IEnumerable<IBooking> GetBookings();

}
