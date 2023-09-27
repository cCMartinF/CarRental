using CarRental.Common.Classes;
using CarRental.Common.Interface;
using CarRental.Data.Interface;

namespace CarRental.Business.Classes;

public class BookingProc
{
    IData _data;
    public BookingProc(IData idata) => _data = idata;

    public IEnumerable<ICustomer> GetCustomers()
    {
        return _data.GetCustomers();
    }

    public IEnumerable<IVehicle> GetVehicles()
    {
        return _data.GetVehicles();
    }
}