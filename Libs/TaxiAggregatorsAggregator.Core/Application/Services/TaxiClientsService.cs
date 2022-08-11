namespace TaxiAggregatorsAggregator.Core.Application.Services;

internal class TaxiClientsService : ITaxiClientsService
{
    private readonly IList<IClient> _clients;

    public TaxiClientsService(IList<IClient> clients)
    {
        _clients = clients;
    }

    public BookingStatus? AddBooking(DateTime bookingTime, Point clintLocation, RequiredCar car)
    {
        BookingStatus? status = null;

        foreach (var client in _clients)
        {
            status = client.AddBooking(bookingTime, clintLocation, car);
            if (status.IsBooked)
                break;
        }

        return status;
    }

    public bool UndoBooking(string bookingId, string taxiClient)
    {
        var client = _clients.FirstOrDefault(_ => _.GetType().Name == taxiClient);

        return client?.UndoBooking(bookingId, taxiClient) ?? false;
    }
}