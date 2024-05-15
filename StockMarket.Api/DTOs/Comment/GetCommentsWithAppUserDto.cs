namespace StockMarket.Api.DTOs;

public class GetCommentsWithAppUserDto : GetCommentDto
{
	public GetUserDto? AppUser { get; set; }
}
