namespace TaxiAggregatorsAggregator.Core.Contracts.BaseModels;

internal interface IAggregatorSubscriber
{
    public void Subscribe(IAggregatorPublisherProxy publisher);
    public void Unsubscribe(IAggregatorPublisherProxy publisher);
}