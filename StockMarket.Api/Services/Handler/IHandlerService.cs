namespace StockMarket.Api.Services;

public interface IHandlerService
{
	List<string> GetResultErrors(IEnumerable<IdentityError> resultErrors);
}
