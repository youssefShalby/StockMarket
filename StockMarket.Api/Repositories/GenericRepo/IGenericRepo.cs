
namespace StockMarket.Api.Repositories;

public interface IGenericRepo<T> where T : class
{
	Task<IEnumerable<T>> GetAllAsync(int pageNumber);
	Task<T> GetByIdAsync(int id);
	Task<CommonResponse> CreateAsync(T entity);
	Task<CommonResponse> UpdateAsync(int id, T entity);
	void Update(T entity);
	Task<CommonResponse> DeleteAsync(int id);
}
