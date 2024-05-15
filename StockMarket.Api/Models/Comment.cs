
namespace StockMarketApp.Models;

public class Comment
{
	public int Id { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Content { get; set; } = string.Empty;
	public DateTime CreatedOn { get; set; } = DateTime.Now;

	[ForeignKey(nameof(Stock))]
	public int? StockId { get; set; }

	[ForeignKey(nameof(AppUser))]
	public string? AppUserId { get; set; }

    //> navigation property
    public Stock? Stock { get; set; }
    public ApplicationUser? AppUser { get; set; }
}
