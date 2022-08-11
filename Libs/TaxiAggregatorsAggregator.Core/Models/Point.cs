namespace TaxiAggregatorsAggregator.Core.Models;

public class Point
{
    public double Latitude { get; set; }

    public double Longitude { get; set; }

    private string? Description { get; set; }
}