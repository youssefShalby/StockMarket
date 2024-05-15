namespace StockMarket.Api.Services;

public interface IPortfolioService
{
	Task<IEnumerable<GetStockDto>> GetUserPortfolioAsync(ApplicationUser user);
	Task<CommonResponse> CreatePortfolioAsync(CreatePortfolioDto model);
	Task<CommonResponse> DeletePortfolioAsync(DeletePortfolioDto model);
}
