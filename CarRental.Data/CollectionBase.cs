

using CarRental.Common.Enum;
using CarRental.Common.Interface;

namespace CarRental.Data;

public class CollectionBase : IData
{
    public IEnumerable<ICustomer> GetCustomers();
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default);
    public IEnumerable<IBooking> GetBookings();
}
