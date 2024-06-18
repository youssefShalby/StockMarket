

namespace StockMarket.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class CommentsController : ControllerBase
{
	private readonly ICommentService _commentService;
	private readonly IConfiguration _configuration;
	private readonly string _getCommentsKey;
    public CommentsController(ICommentService commentService, IConfiguration configuration)
    {
        _commentService = commentService;
		_configuration = configuration;
		_getCommentsKey = _configuration["GetCommentsKey"];
    }

    [HttpGet("All/{pageNumber}")]
    public async Task<ActionResult> GetAll([FromRoute]int pageNumber, [FromHeader]string key)
    {
		if(key != _getCommentsKey)
		{
			return BadRequest("The key to get all comments is not valid, the admin only can have this key");
		}
        var comments = await _commentService.GetAllAsync(pageNumber);
		if (comments is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comments);
	}

	[HttpGet("GetUserComments/{pageNumber}")]
	public async Task<ActionResult> GetAllByUserId(int pageNumber)
	{
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}

		var userId = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier)?.Value ?? "NA";

		if (userId == "NA") return BadRequest("user not found..!!!");

		var model = new GetAllByUserIdDto
		{
			UserId = userId,
			PageNumber = pageNumber
		}; 

		var comments = await _commentService.GetAllByUserId(model);
		if (comments is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comments);
	}

	[HttpGet("UsersComments/{pageNumber}")]
	public async Task<ActionResult> GetAllWithUser([FromRoute] int pageNumber, [FromHeader] string key)
	{
		if (key != _getCommentsKey)
		{
			return BadRequest("The key to get all comments is not valid, the admin only can have this key");
		}

		var comments = await _commentService.GetAllWithIncludesAsync(pageNumber);
		if (comments is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(comments);
	}

	[HttpGet("{id:int}")]
	public async Task<ActionResult> GetById([FromRoute] int id, [FromHeader] string key)
	{
		if (key != _getCommentsKey)
		{
			return BadRequest("The key to get all comments is not valid, the admin only can have this key");
		}

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

	[HttpPut("{id:int}")]
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
