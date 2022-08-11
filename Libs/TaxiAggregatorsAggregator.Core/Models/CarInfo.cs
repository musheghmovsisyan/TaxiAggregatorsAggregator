namespace TaxiAggregatorsAggregator.Core.Models;

public class CarInfo
{
    public string DriverName { get; set; } = null!;

    public string DriverPhone { get; set; } = null!;

    public string CarNumber { get; set; } = null!;

    public string CarColor { get; set; } = null!;

    public CarType CarType { get; set; }
}