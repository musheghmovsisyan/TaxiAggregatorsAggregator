namespace TaxiAggregatorsAggregator.Core.Contracts.Services;

internal interface ITaxiAggregatorsService
{
    IList<ProposaleInfo> GetProposals(string[] cityBlocks, string[] streets, RequiredCar car, Point carLocation, bool onlyOnce = false);
}