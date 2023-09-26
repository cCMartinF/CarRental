
namespace CarRental.Common.Interface;

public interface ICustomer
{
    public long sSD { get; init; }
    public string firstName { get; init; }
    public string lastName { get; init; }
}
