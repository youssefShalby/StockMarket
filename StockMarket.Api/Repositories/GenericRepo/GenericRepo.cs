
namespace StockMarket.Api.Repositories;

public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
{
	private readonly AppDbContext _context;
    public GenericRepo(AppDbContext context)
    {
        _context = context;
    }

    public async Task<CommonResponse> CreateAsync(TEntity entity)
	{
		try
		{
			await _context.Set<TEntity>().AddAsync(entity);
			_context.SaveChanges();
			return new CommonResponse("Created", true);
		}
		catch (Exception ex)
		{
			return new CommonResponse(ex.Message, false);
		}
	}

	public async Task<CommonResponse> DeleteAsync(int id)
	{
		try
		{
			var entityToDelete = await GetByIdAsync(id);
			_context.Set<TEntity>().Remove(entityToDelete);
			_context.SaveChanges();
			return new CommonResponse("Deleted..!!", true);
		}
		catch (Exception ex)
		{
			return new CommonResponse(ex.Message, false);
		}
	}

	public async Task<IEnumerable<TEntity>> GetAllAsync(int pageNumber)
	{
		return await _context.Set<TEntity>()
			.AsNoTracking()
			.Skip((pageNumber - 1) * 10).Take(10) //> get 10 by 10
			.ToListAsync();
	}

	public async Task<TEntity> GetByIdAsync(int id)
	{
		return await _context.Set<TEntity>().FindAsync(id) ?? default!;
	}

	public void Update(TEntity entity)
	{
		_context.Set<TEntity>().Update(entity);
		_context.SaveChanges();
	}

	public async Task<CommonResponse> UpdateAsync(int id, TEntity entity)
	{
		try
		{
			var theEntity = await GetByIdAsync(id);
			_context.Set<TEntity>().Update(theEntity);
			_context.SaveChanges();
			return new CommonResponse("Updated..!!", true);
		}
		catch (Exception ex)
		{
			return new CommonResponse(ex.Message, false);
		}
	}
}
