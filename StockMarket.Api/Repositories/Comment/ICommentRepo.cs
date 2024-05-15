namespace StockMarket.Api.Repositories;

public interface ICommentRepo : IGenericRepo<Comment>
{
	Task<IEnumerable<Comment>> GetAllWithAIncludeAsync(int pageNumber);
	Task<IEnumerable<Comment>> GetAllByUserId(string userId, int pageNumber);

	//> add custome operations here if needed
}
