namespace StockMarket.Api.DTOs;

public class GetAllByUserIdDto
{
    public string UserId { get; set; } = string.Empty;
    public int PageNumber  { get; set; }
}
