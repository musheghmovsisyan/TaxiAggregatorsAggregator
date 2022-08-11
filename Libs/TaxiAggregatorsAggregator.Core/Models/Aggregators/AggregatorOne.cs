namespace TaxiAggregatorsAggregator.Core.Models.Aggregators;

internal class AggregatorOne : IAggregator, IAggregatorSubscriber
{
    private string _aggregatorId;
    private string _aggregatorKey;
    private readonly IAggregatorPublisherProxy _publisher;

    public AggregatorOne(string aggregatorId, string aggregatorKey, IAggregatorPublisherProxy publisher)
    {
        _aggregatorId = aggregatorId;
        _aggregatorKey = aggregatorKey;
        _publisher = publisher;
    }

    public ProposaleInfo GetProposals(string[] cityBlocks, string[] streets, RequiredCar car, Point carLocation,
        bool onlyOnce = false)
    {
        if (onlyOnce)
            Subscribe(_publisher);

        throw new NotImplementedException();
    }

    public void Subscribe(IAggregatorPublisherProxy publisher)
    {
        throw new NotImplementedException();
    }

    public void Unsubscribe(IAggregatorPublisherProxy publisher)
    {
        throw new NotImplementedException();
    }
}