namespace StockMarket.Api.DTOs;

public class GetStockDto
{
	public string Symbol { get; set; } = string.Empty;
	public string CompanyName { get; set; } = string.Empty;
	public decimal Price { get; set; }
	public decimal LatestProfit { get; set; }
	public long MarketValue { get; set; }
	public string Industry { get; set; } = string.Empty;
}
