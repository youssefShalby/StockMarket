namespace StockMarketApp.ModelsConfigurations;

public class AppUserTypeConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
	public void Configure(EntityTypeBuilder<ApplicationUser> modelBuilder)
	{
		modelBuilder.HasKey(U => U.Id);

		//> add another configurations for properties here..
	}
}
