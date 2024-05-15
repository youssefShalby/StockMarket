
namespace StockMarket.Api.Services;

public class CommentService : ICommentService
{
	private readonly ICommentRepo _commentRepo;
    public CommentService(ICommentRepo commentRepo)
    {
        _commentRepo = commentRepo;
    }

    public async Task<CommonResponse> CreateAsync(CreateCommentDto model)
	{
		var comment = CommentMapper.ToCommentModel(model);
		return await _commentRepo.CreateAsync(comment);
	}

	public async Task<CommonResponse> DeleteAsync(int id)
	{
		return await _commentRepo.DeleteAsync(id);
	}

	public async Task<IEnumerable<GetCommentDto>> GetAllAsync(int pageNumber)
	{
		var comments = await _commentRepo.GetAllAsync(pageNumber);
		return comments.Select(comment => CommentMapper.ToCommentDto(comment));
	}

	public async Task<IEnumerable<GetCommentDto>> GetAllByUserId(GetAllByUserIdDto model)
	{
		var comments =await _commentRepo.GetAllByUserId(model.UserId, model.PageNumber);
		return comments.Select(comment => CommentMapper.ToCommentDto(comment));
	}

	public async Task<IEnumerable<GetCommentsWithAppUserDto>> GetAllWithIncludesAsync(int pageNumber)
	{
		var comments = await _commentRepo.GetAllWithAIncludeAsync(pageNumber);
		return comments.Select(comment => new GetCommentsWithAppUserDto
		{
			Content = comment.Content,
			CreatedOn = comment.CreatedOn,
			Title = comment.Title,
			AppUser = new GetUserDto
			{
				Email = comment.AppUser?.Email ?? "NA",
				UserName = comment.AppUser?.UserName ?? "NA"
			}
		});
	}

	public async Task<GetCommentDto> GetByIdAsync(int id)
	{
		var comment = await _commentRepo.GetByIdAsync(id);
		return CommentMapper.ToCommentDto(comment);
	}

	public async Task<CommonResponse> UpdateAsync(int id, UpdateCommentDto entity)
	{
		var commentToUpdate = await _commentRepo.GetByIdAsync(id);
		if(commentToUpdate is null)
		{
			return new CommonResponse("cannot find the comment..!", false) ;
		}

		commentToUpdate.Content = entity.Content;
		commentToUpdate.Title = entity.Title;

		_commentRepo.Update(commentToUpdate);
		return new CommonResponse("Updated..!", true);
	}
}
