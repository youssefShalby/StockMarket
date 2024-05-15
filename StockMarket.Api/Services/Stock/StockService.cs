
namespace StockMarket.Api.Services;

public class StockService : IStockService
{
	private readonly IStockRepo _stockRepo;
    public StockService(IStockRepo stockRepo)
    {
		_stockRepo = stockRepo;
    }
    public async Task<CommonResponse> CreateAsync(CreateStockDto model)
	{
		var stock = StockMapper.ToStockModel(model);
		return await _stockRepo.CreateAsync(stock);
	}

	public async Task<CommonResponse> DeleteAsync(int id)
	{
		return await _stockRepo.DeleteAsync(id);
	}

	public async Task<IEnumerable<GetStockDto>> GetAllAsync(int pageNumner)
	{
		var stocks = await _stockRepo.GetAllAsync(pageNumner);
		return stocks.Select(stock => StockMapper.TStockDto(stock));
	}

	public async Task<IEnumerable<GetStockWithCommentDto>> GetAlldWithCommentIncludeAsync(int pageNumber)
	{
		var stockWithComments = await _stockRepo.GetAlldWithCommentIncludeAsync(pageNumber);
		return stockWithComments.Select(stock => new GetStockWithCommentDto
		{
			CompanyName = stock.CompanyName,
			Industry = stock.Industry,
			LatestProfit = stock.LatestProfit,
			Price = stock.Price,
			MarketValue = stock.MarketValue,
			Symbol = stock.Symbol,
			Comments = stock.Comments.Select(comment => CommentMapper.ToCommentDto(comment))
		});
	}

	public async Task<IEnumerable<GetStockDto>> GetAllWithFilterAsync(StockQueryHandler handler)
	{
		var filteredStocks = await _stockRepo.GetAllWithFilterAsync(handler);
		return filteredStocks.Select(stock => StockMapper.TStockDto(stock));
	}

	public async Task<GetStockDto> GetByIdAsync(int id)
	{
		var stock = await _stockRepo.GetByIdAsync(id);
		return StockMapper.TStockDto(stock);
	}

	public async Task<GetStockWithCommentDto> GetByIdWithCommentIncludeAsync(int id)
	{
		var stock = await _stockRepo.GetByIdWithCommentIncludeAsync(id);
		if(stock is null)
		{
			return null!;
		}

		return new GetStockWithCommentDto
		{
			MarketValue = stock.MarketValue,
			CompanyName = stock.CompanyName,
			Industry = stock.Industry,
			Price = stock.Price,
			Symbol = stock.Symbol,
			LatestProfit = stock.LatestProfit,
			Comments = stock.Comments.Select(comment => new GetCommentDto
			{
				Content = comment.Content,
				CreatedOn = comment.CreatedOn,
				Title = comment.Title
			})
		};
	}

	public async Task<GetStockWithCommentDto> GetBySymbolAsync(string symbol)
	{
		var stock = await _stockRepo.GetBySymbolAsync(symbol);
		return new GetStockWithCommentDto
		{
			CompanyName = stock.CompanyName,
			Industry = stock.Industry,
			LatestProfit = stock.LatestProfit,
			MarketValue = stock.MarketValue,
			Price = stock.Price,
			Symbol = stock.Symbol,
			Comments = stock.Comments.Select(comment => new GetCommentDto
			{
				Content = comment.Content,
				CreatedOn = comment.CreatedOn,
				Title = comment.Title
			})
		};
	}

	public async Task<CommonResponse> UpdateAsync(int id, UpdateStockDto entity)
	{
		var stockToUpdate = await _stockRepo.GetByIdAsync(id);
		if(stockToUpdate is null)
		{
			return new CommonResponse("cannot find the stock...!", false);
		}

		stockToUpdate.Price = entity.Price;
		stockToUpdate.MarketValue = entity.MarketValue;
		stockToUpdate.LatestProfit = entity.LatestProfit;
		stockToUpdate.CompanyName = entity.CompanyName;
		stockToUpdate.Industry = entity.Industry;
		stockToUpdate.Symbol = entity.Symbol;

		_stockRepo.Update(stockToUpdate);
		return new CommonResponse("Updated..!!", true);
	}
}
