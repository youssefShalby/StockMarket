
namespace StockMarketApp.Repositories;

public interface IStockRepo : IGenericRepo<Stock>
{
	Task<Stock> GetBySymbolAsync(string symbol);
	Task<Stock> GetByIdWithCommentIncludeAsync(int id);
	Task<IEnumerable<Stock>> GetAlldWithCommentIncludeAsync(int pageNumber);
	Task<IReadOnlyList<Stock>> GetAllWithFilterAsync(StockQueryHandler handler);

	//> Add another operations here...
}
