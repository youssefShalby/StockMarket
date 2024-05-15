namespace StockMarket.Api.Repositories;

public interface IPortfolioRepo
{
	Task<IEnumerable<Stock>> GetUserPortfolioAsync(ApplicationUser user);
	Task CreatePortfolioAsync(AppUserStock model);
	Task DeletePortfolio(AppUserStock model);
	Task<AppUserStock> GetPortfolioAsync(string userId, int stockId);
}
