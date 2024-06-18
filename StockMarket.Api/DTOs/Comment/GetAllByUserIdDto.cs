

namespace StockMarket.Api.DTOs;
public class GetAllByUserIdDto
{
    [JsonIgnore]
    public string UserId { get; set; } = string.Empty;
    public int PageNumber  { get; set; }
}
