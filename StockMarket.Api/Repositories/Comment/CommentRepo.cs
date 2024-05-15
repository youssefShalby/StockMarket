
namespace StockMarketApp.Repositories;

public class CommentRepo : GenericRepo<Comment>, ICommentRepo
{
	private readonly AppDbContext _context;
	public CommentRepo(AppDbContext context) : base(context)
	{
		_context = context;
	}

	public async Task<IEnumerable<Comment>> GetAllWithAIncludeAsync(int pageNumner)
	{
		return await _context.Set<Comment>()
			.AsNoTracking()
			.Include(C => C.AppUser)
			.Skip((pageNumner - 1) * 10)
			.Take(10)
			.ToListAsync();
	}

	public async Task<IEnumerable<Comment>> GetAllByUserId(string userId, int pageNumber)
	{
		return await _context.Set<Comment>()
			.AsNoTracking()
			.Where(comment => comment.AppUserId == userId)
			.Skip((pageNumber - 1) * 10).Take(10)
			.ToListAsync();
	}

	//> impelement custome operations here if needed..
}
