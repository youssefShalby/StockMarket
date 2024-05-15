
namespace StockMarketApp.ModelsConfigurations;

public class StockTypeConfiguration : IEntityTypeConfiguration<Stock>
{
	public void Configure(EntityTypeBuilder<Stock> modelBuilder)
	{
		modelBuilder.HasKey(S => S.Id);
		modelBuilder.HasData(StockDummyData.dummyStocks);

		//> add another configurations for the properties here
	}
}
