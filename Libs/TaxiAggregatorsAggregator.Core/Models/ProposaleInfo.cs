namespace TaxiAggregatorsAggregator.Core.Models;

public class ProposaleInfo
{
    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public Point ClientLocation { get; set; } = null!;

    public RequiredCar RequiredCar { get; set; } = null!;
}