namespace StockMarket.Api.DTOs;

public class CreatePortfolioDto
{
    public string UserId { get; set; } = string.Empty;
    public int StockId { get; set; }
}
