
namespace StockMarket.Api.Services;

public class PortfolioService : IPortfolioService
{
	private readonly IPortfolioRepo _portfolioRepo;
    public PortfolioService(IPortfolioRepo portfolioRepo)
    {
        _portfolioRepo = portfolioRepo;
    }

	public async Task<CommonResponse> CreatePortfolioAsync(CreatePortfolioDto model)
	{
		try
		{
			AppUserStock newPortfolio = new AppUserStock()
			{
				AppUserId = model.UserId,
				StockId = model.StockId
			};
			await _portfolioRepo.CreatePortfolioAsync(newPortfolio);
			return new CommonResponse("relation created..!", true); 
		}
		catch(Exception ex)
		{
			return new CommonResponse(ex.Message, false);
		}
	}

	public async Task<CommonResponse> DeletePortfolioAsync(DeletePortfolioDto model)
	{
		try
		{
			var portfolio = await _portfolioRepo.GetPortfolioAsync(model.UserId, model.StockId);
			await _portfolioRepo.DeletePortfolio(portfolio);
			return new CommonResponse("Relation Deleted..!!", true);
		}
		catch (Exception ex)
		{
			return new CommonResponse(ex.Message, false);
		}
	}

	public async Task<IEnumerable<GetStockDto>> GetUserPortfolioAsync(ApplicationUser user)
    {
        var stocksPortfolio = await _portfolioRepo.GetUserPortfolioAsync(user);
        return stocksPortfolio.Select(stock => StockMapper.TStockDto(stock));
	}
}
