namespace TaxiAggregatorsAggregator.Core.Contracts.BaseModels;

public interface IAggregator
{
    public ProposaleInfo GetProposals(string[] cityBlocks, string[] streets, RequiredCar car, Point carLocation, bool onlyOnce = false);
}