namespace TaxiAggregatorsAggregator.Core.Contracts.Services;

internal interface ITaxiClientsService
{
    BookingStatus? AddBooking(DateTime bookingTime, Point clintLocation, RequiredCar car);
    bool UndoBooking(string bookingId, string taxiClient);
}