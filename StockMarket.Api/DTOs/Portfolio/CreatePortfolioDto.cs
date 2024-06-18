namespace StockMarket.Api.DTOs;

public class CreatePortfolioDto
{
    [JsonIgnore]
    public string UserId { get; set; } = string.Empty;
    public int StockId { get; set; }
}
