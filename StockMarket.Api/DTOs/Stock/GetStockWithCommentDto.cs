namespace StockMarket.Api.DTOs;

public class GetStockWithCommentDto : GetStockDto
{
    public IEnumerable<GetCommentDto> Comments { get; set; } = new HashSet<GetCommentDto>();
}
