namespace StockMarket.Api.Mappers;

public class StockMapper
{
	public static Stock ToStockModel(CreateStockDto model)
	{
		return new Stock
		{
			CompanyName = model.CompanyName,
			Industry = model.Industry,
			LatestProfit = model.LatestProfit,
			Price = model.Price,
			Symbol = model.Symbol,
			MarketValue = model.MrketValue,
		};
	}
	
	public static GetStockDto TStockDto(Stock model)
	{
		return new GetStockDto
		{
			MarketValue = model.MarketValue,
			CompanyName = model.CompanyName,
			Industry = model.Industry,
			Price = model.Price,
			Symbol = model.Symbol,
			LatestProfit = model.LatestProfit,
		};
	}
}
