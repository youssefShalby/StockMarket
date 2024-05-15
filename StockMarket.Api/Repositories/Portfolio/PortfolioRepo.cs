

namespace StockMarket.Api.Repositories;

public class PortfolioRepo : IPortfolioRepo
{
	private readonly AppDbContext _context;
    public PortfolioRepo(AppDbContext context)
    {
        _context = context;
    }

	public async Task CreatePortfolioAsync(AppUserStock model)
	{
        await _context.Set<AppUserStock>().AddAsync(model);
		await _context.SaveChangesAsync();
	}

	public async Task DeletePortfolio(AppUserStock model)
	{
        _context.Set<AppUserStock>().Remove(model);
        await _context.SaveChangesAsync();
	}

	public async Task<AppUserStock> GetPortfolioAsync(string userId, int stockId)
	{
        return await _context.Set<AppUserStock>().FirstOrDefaultAsync(APS => APS.AppUserId == userId && APS.StockId == stockId) ?? new();
	}

	public async Task<IEnumerable<Stock>> GetUserPortfolioAsync(ApplicationUser user)
	{
        try
        {
            //> get all users has foreign key in [AppUeserStocks] table
            var portfolio = _context.AppUserStocks.Where(U => U.AppUser!.Id == user.Id);

            //> then get the stocks of each got user
            var stocks = await portfolio.Select(stock => new Stock
            {
                Id = stock.StockId,
                CompanyName = stock.Stock!.CompanyName,
                Industry = stock.Stock!.Industry,
                LatestProfit = stock.Stock!.LatestProfit,
                MarketValue = stock.Stock!.MarketValue,
                Price = stock.Stock!.Price,
                Symbol = stock.Stock!.Symbol,

            }).ToListAsync();
            return stocks; 
		}
        catch (Exception) 
        {
            return null!;
        }
	}
}
