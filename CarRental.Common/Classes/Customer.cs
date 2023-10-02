using CarRental.Common.Interface;

namespace CarRental.Common.Classes;

public class Customer : ICustomer
{
    public long sSD { get; init; }
    public string firstName { get; init; }
    public string lastName { get; init; }

    public Customer(long nSSD, string nFirstName, string nLastName) =>
        (sSD, firstName, lastName) = (nSSD, nFirstName, nLastName);
}
