namespace StockMarket.Api.DTOs;

public class GetCommentDto
{
	public string Title { get; set; } = string.Empty;
	public string Content { get; set; } = string.Empty;
	public DateTime CreatedOn { get; set; } = DateTime.Now;
}
