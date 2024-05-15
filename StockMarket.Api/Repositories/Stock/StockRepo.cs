


namespace StockMarketApp.Repositories;

public class StockRepo : GenericRepo<Stock>, IStockRepo
{
	private readonly AppDbContext _context;
    public StockRepo(AppDbContext context) : base(context)
    {
		_context = context;
    }

	public async Task<IEnumerable<Stock>> GetAlldWithCommentIncludeAsync(int pageNumber)
	{
		return await _context.Set<Stock>()
			.AsNoTracking()
			.Include(S => S.Comments)
			.Skip((pageNumber - 1) * 10)
			.Take(10)
			.ToListAsync();
	}

	public async Task<IReadOnlyList<Stock>> GetAllWithFilterAsync(StockQueryHandler handler)
	{
		//> get stocks, and make the result AsQueryable to be able to add another query filter
		var stocks = _context.Set<Stock>().AsNoTracking().AsQueryable();

		#region Filter

		if (!string.IsNullOrWhiteSpace(handler.Symbol))
		{
			stocks = stocks.Where(stock => stock.Symbol.Contains(handler.Symbol));
		}

		if (!string.IsNullOrWhiteSpace(handler.CompanyName))
		{
			stocks = stocks.Where(stock => stock.CompanyName.Contains(handler.CompanyName));
		}

		#endregion

		#region Sorting

		if (!string.IsNullOrWhiteSpace(handler.SortBy))
		{
			if(handler.SortBy.Equals("price"))
			{
				stocks = handler.IsDescending ? stocks.OrderByDescending(s => s.Price) : stocks.OrderBy(s => s.Price);
			}

			if (handler.SortBy.Equals("market"))
			{
				stocks = handler.IsDescending ? stocks.OrderByDescending(s => s.MarketValue) : stocks.OrderBy(s => s.MarketValue);
			}
		}

		#endregion

		#region Pagination

		stocks = stocks.Skip((handler.PageNumber - 1) * handler.PageSize).Take(handler.PageSize);

		#endregion

		//> then return stocks as Enumerable
		return await stocks.ToListAsync();

	}

	public async Task<Stock> GetByIdWithCommentIncludeAsync(int id)
	{
		return await _context.Set<Stock>()
			.Include(S =>S.Comments)
			.AsNoTracking()
			.FirstOrDefaultAsync(S => S.Id == id) ?? new();
	}

	public async Task<Stock> GetBySymbolAsync(string symbol)
	{
		return await _context.Set<Stock>().Include(S => S.Comments).FirstOrDefaultAsync(S => S.Symbol == symbol) ?? new();
	}


	//> impelement another operations here if needed..
}
