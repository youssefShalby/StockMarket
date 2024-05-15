namespace StockMarket.Api.Services;
public interface IStockService
{
	Task<IEnumerable<GetStockDto>> GetAllAsync(int pageNumber);
	Task<IEnumerable<GetStockDto>> GetAllWithFilterAsync(StockQueryHandler handler);
	Task<IEnumerable<GetStockWithCommentDto>> GetAlldWithCommentIncludeAsync(int pageNumber);
	Task<GetStockDto> GetByIdAsync(int id);
	Task<GetStockWithCommentDto> GetByIdWithCommentIncludeAsync(int id);
	Task<GetStockWithCommentDto> GetBySymbolAsync(string symbol);

	Task<CommonResponse> CreateAsync(CreateStockDto model);
	Task<CommonResponse> UpdateAsync(int id, UpdateStockDto entity);
	Task<CommonResponse> DeleteAsync(int id);

}
