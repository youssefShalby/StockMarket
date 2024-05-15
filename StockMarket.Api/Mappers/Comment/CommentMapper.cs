namespace StockMarket.Api.Mappers;

public class CommentMapper
{
	public static Comment ToCommentModel(CreateCommentDto model)
	{
		return new Comment
		{
			Title = model.Title,
			Content = model.Content,
			StockId = model.StockId,
			AppUserId = model.UserId
		};
	}

	public static GetCommentDto ToCommentDto(Comment comment)
	{
		return new GetCommentDto
		{
			Content = comment.Content,
			CreatedOn = comment.CreatedOn,
			Title = comment.Title,
			
		};
	}
}
