

namespace StockMarket.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CommentsController : ControllerBase
{
	private readonly ICommentService _commentService;
    public CommentsController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    [HttpGet("{pageNumber}")]
    public async Task<ActionResult> GetAll([FromRoute]int pageNumber)
    {
        var comments = await _commentService.GetAllAsync(pageNumber);
		if (comments is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comments);
	}

	[HttpGet]
	public async Task<ActionResult> GetAllByUserId([FromBody] GetAllByUserIdDto model)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}
		var comments = await _commentService.GetAllByUserId(model);
		if (comments is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comments);
	}

	[HttpGet("U/{pageNumber}")]
	public async Task<ActionResult> GetAllWithUser([FromRoute] int pageNumber)
	{
		var comments = await _commentService.GetAllWithIncludesAsync(pageNumber);
		if (comments is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comments);
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult> GetById([FromRoute] int id)
	{
		var comment = await _commentService.GetByIdAsync(id);
		if (comment is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comment);
	}

	[HttpPost]
	public async Task<ActionResult> Create([FromBody] CreateCommentDto model)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}

		var result = await _commentService.CreateAsync(model);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return Ok(result);
	}

	[HttpPost("{id:int}")]
	public async Task<ActionResult> Update([FromRoute] int id, [FromBody] UpdateCommentDto model)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}

		var result = await _commentService.UpdateAsync(id, model);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return Ok(result);
	}

	[HttpDelete("{id:int}")]
	public async Task<ActionResult> Delete([FromRoute] int id)
	{
		var result = await _commentService.DeleteAsync(id);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return StatusCode(200, result);
	}
}
