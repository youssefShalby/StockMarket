
namespace StockMarketApp.Models;

public class ApplicationUser : IdentityUser
{
	public IEnumerable<Comment> Comments { get; set; }
	public IEnumerable<AppUserStock> AppUserStocks { get; set; }
    public ApplicationUser()
    {
        AppUserStocks = new HashSet<AppUserStock>();
        Comments = new HashSet<Comment>();

    }
}
