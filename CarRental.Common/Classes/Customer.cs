using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Customer : ICustomer
{
    public int sSD { get; init; }
    public string firstName { get; init; }
    public string lastName { get; init; }
}
