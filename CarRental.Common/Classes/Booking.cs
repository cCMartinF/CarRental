using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Booking : IBooking
{
    public IVehicle Vehicle { get; init; }
    public ICustomer Customer { get; init; }
    public int? KmReturned { get; init; }
    public double? Cost { get; set; }
    public int DaysRented { get; set; }
    public DateTime? Returned { get; set; }


    public Booking(IVehicle vehicle, ICustomer customer, int? kmReturned)
    {
        this.Vehicle = vehicle;
        this.Customer = customer;
        this.KmReturned = kmReturned;
        if(kmReturned != null)
        ReturnVehicle(vehicle);
    }


    void ReturnVehicle(IVehicle Vehicle)
    {
        if (Vehicle.Rented != null)
        {
            Returned = DateTime.Now;
            var diffOfDates = Returned - Vehicle.Rented;
            DaysRented = diffOfDates.Value.Days;
            Cost = DaysRented * Vehicle.CostDay + Vehicle.CostKM * KmReturned;
        }
        else
            return;
    }
}
