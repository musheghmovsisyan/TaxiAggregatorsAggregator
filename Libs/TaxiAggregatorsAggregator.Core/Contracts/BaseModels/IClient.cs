namespace TaxiAggregatorsAggregator.Core.Contracts.BaseModels;

internal interface IClient
{
    public BookingStatus AddBooking(DateTime bookingTime, Point clintLocation, RequiredCar car);
    public bool UndoBooking(string bookingId, string taxiClient);
}