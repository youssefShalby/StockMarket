namespace StockMarket.Api.DTOs;

public class TokenDto
{
    public string Token { get; set; } = string.Empty;
    public DateTime ExpireTime { get; set; }
}
