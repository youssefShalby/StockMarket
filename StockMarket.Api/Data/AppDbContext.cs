
namespace StockMarketApp.Data;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
		//> pass the options to the base class(IdentityDbContext)
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		//> call external configuration
		new StockTypeConfiguration().Configure(modelBuilder.Entity<Stock>());
		new CommentTypeConfiguration().Configure(modelBuilder.Entity<Comment>());

		//> initial the relations
		modelBuilder.Entity<Stock>()
			.HasMany(S => S.Comments)
			.WithOne(C => C.Stock)
			.HasForeignKey(C => C.StockId)
			.OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<ApplicationUser>()
			.HasMany(U => U.Comments)
			.WithOne(C => C.AppUser)
			.HasForeignKey(C => C.AppUserId)
			.OnDelete(DeleteBehavior.Cascade);

		modelBuilder.Entity<Stock>()
			.HasMany(S => S.AppUserStocks)
			.WithOne(AS => AS.Stock)
			.HasForeignKey(As => As.StockId)
			.OnDelete(DeleteBehavior.NoAction);

		modelBuilder.Entity<ApplicationUser>()
			.HasMany(U => U.AppUserStocks)
			.WithOne(AS => AS.AppUser)
			.HasForeignKey(AS => AS.AppUserId)
			.OnDelete(DeleteBehavior.NoAction);

		modelBuilder.Entity<AppUserStock>()
			.HasKey(AUS => new { AUS.StockId, AUS.AppUserId });
	}

	//> call refernces of domain models
	public DbSet<Stock> Stocks => Set<Stock>();
	public DbSet<Comment> Comments => Set<Comment>();
	public DbSet<AppUserStock> AppUserStocks => Set<AppUserStock>();
	public DbSet<ApplicationUser> AppUsers => Set<ApplicationUser>();

}
