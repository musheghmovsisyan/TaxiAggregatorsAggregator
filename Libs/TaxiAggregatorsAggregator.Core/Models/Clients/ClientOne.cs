namespace TaxiAggregatorsAggregator.Core.Models.Clients;

internal class ClientOne : IClient
{
    private string _clientId;
    private string _clientKey;

    public ClientOne(string clientId, string clientKey)
    {
        _clientId = clientId;
        _clientKey = clientKey;
    }

    public BookingStatus AddBooking(DateTime bookingTime, Point clintLocation, RequiredCar car)
    {
        throw new NotImplementedException();
    }

    public bool UndoBooking(string bookingId, string taxiClient)
    {
        throw new NotImplementedException();
    }
}