namespace TaxiAggregatorsAggregator.Core.Application.Services;

internal class TaxiAggregatorsService : ITaxiAggregatorsService
{
    private readonly IList<IAggregator> _aggregators;

    public TaxiAggregatorsService(IList<IAggregator> aggregators)
    {
        _aggregators = aggregators;
    }

    public IList<ProposaleInfo> GetProposals(string[] cityBlocks, string[] streets, RequiredCar car, Point carLocation, bool onlyOnce = false)
    {
        return _aggregators.Select(_ => _.GetProposals(cityBlocks, streets, car, carLocation, onlyOnce)).ToList();
    }
}