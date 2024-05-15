
namespace StockMarket.Api.Services;

public class HandlerService : IHandlerService
{
	public List<string> GetResultErrors(IEnumerable<IdentityError> resultErrors)
	{
		List<string> convertedErrors = new List<string>(8);
		foreach (var error in resultErrors)
		{
			convertedErrors.Add(error.ToString() ?? "NA");
		}
		return convertedErrors;
	}
}
