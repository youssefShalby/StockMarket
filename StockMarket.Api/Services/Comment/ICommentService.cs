namespace StockMarket.Api.Services;

public interface ICommentService
{
	Task<IEnumerable<GetCommentDto>> GetAllAsync(int pageNumber);
	Task<IEnumerable<GetCommentsWithAppUserDto>> GetAllWithIncludesAsync(int pageNumber);
	Task<GetCommentDto> GetByIdAsync(int id);
	Task<CommonResponse> CreateAsync(CreateCommentDto model);
	Task<CommonResponse> UpdateAsync(int id, UpdateCommentDto entity);
	Task<CommonResponse> DeleteAsync(int id);
	Task<IEnumerable<GetCommentDto>> GetAllByUserId(GetAllByUserIdDto model);

}
