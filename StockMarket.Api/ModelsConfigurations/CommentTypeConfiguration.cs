
namespace StockMarketApp.ModelsConfigurations;

public class CommentTypeConfiguration : IEntityTypeConfiguration<Comment>
{
	public void Configure(EntityTypeBuilder<Comment> modelBuilder)
	{
		modelBuilder.HasKey(C =>  C.Id);
		modelBuilder.HasData(CommentDummyData.comments);

		//> add other configuration here
	}
}
