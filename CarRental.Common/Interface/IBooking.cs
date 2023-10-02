

namespace CarRental.Common.Interface;

public interface IBooking
{
    public IVehicle Vehicle { get; init; }
    public ICustomer Customer { get; init; }
    public int? KmReturned { get; init; }
    public double? Cost { get; set; }
    public DateTime? Returned {get; set; }


}
