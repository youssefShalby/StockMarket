namespace StockMarketApp.Models;


//> model represent M:M relation between [User & Stock]
public class AppUserStock
{
    [ForeignKey(nameof(Stock))]
    public int StockId { get; set; }

    [ForeignKey(nameof(AppUser))]
    public string? AppUserId { get; set; }
    public Stock? Stock { get; set; }
    public ApplicationUser? AppUser { get; set; }
}
