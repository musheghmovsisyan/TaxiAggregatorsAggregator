namespace TaxiAggregatorsAggregator.Core.Models;

internal class BookingStatus
{
    public string BookingId { get; set; } = null!;

    public DateTime BookingTime { get; set; }

    public Point BookingPoint { get; set; } = null!;

    public CarInfo CarInfo { get; set; } = null!;

    public bool IsBooked { get; set; }
}