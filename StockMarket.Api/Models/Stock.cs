
namespace StockMarketApp.Models;

public class Stock
{
    public int Id { get; set; }
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public decimal Price { get; set; }
	public decimal LatestProfit { get; set; }
    public long MarketValue { get; set; }
    public string Industry { get; set; } = string.Empty;


    //> navigation properties
    public IEnumerable<Comment> Comments { get; set; }
    public IEnumerable<AppUserStock> AppUserStocks { get; set; }
	public Stock()
	{
		AppUserStocks = new HashSet<AppUserStock>();
        Comments = new HashSet<Comment>();
	}

}
