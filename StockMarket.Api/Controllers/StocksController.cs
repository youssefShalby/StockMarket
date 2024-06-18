

namespace StockMarket.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class StocksController : ControllerBase
{
	private readonly IStockService _stockService;
	private readonly IConfiguration _configuration;
	private readonly string _getCommentsKey;
	public StocksController(IStockService stockService, IConfiguration configuration)
    {
        _stockService = stockService;
		_configuration = configuration;
		_getCommentsKey = _configuration["GetCommentsKey"];
	}

    [HttpGet("All/{pageNumber}")]
    public async Task<ActionResult> GetAll([FromRoute]int pageNumber, [FromHeader]string key)
    {
		//> no anyone can get all stocks of system by this endpoint, the admin that have a key only can get all stocks
		if (key != _getCommentsKey)
		{
			return BadRequest("The key to get all comments is not valid, the admin only can have this key");
		}

		var stocks = await _stockService.GetAllAsync(pageNumber);
        if(stocks is null)
        {
            return BadRequest("cannot get the stocks right now, try again later..!!");
        }
        return Ok(stocks);
    }

	[HttpGet("AllStocksWithComments/{pageNumber}")]
	public async Task<ActionResult> GetAllWithComments([FromRoute] int pageNumber)
	{
		//> can access all stocks with comments from this endpoint
		var stocks = await _stockService.GetAlldWithCommentIncludeAsync(pageNumber);
		if (stocks is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(stocks);
	}

	[HttpGet("filter")]
	public async Task<ActionResult> GetAllWithFilters([FromBody] StockQueryHandler handler)
	{
		//> can access all stocks with comments from this endpoint and user [filter, sort and pagination]
		var stocks = await _stockService.GetAllWithFilterAsync(handler);
		if (stocks is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(stocks);
	}

	[HttpGet("{id:int}")]
    public async Task<ActionResult> GetById([FromRoute]int id, [FromHeader] string key)
    {
		//> no anyone can access the stock by Id except the Admin
		if (key != _getCommentsKey)
		{
			return BadRequest("The key to get all comments is not valid, the admin only can have this key");
		}
		var stock = await _stockService.GetByIdAsync(id);
        if(stock is null)
        {
			return BadRequest("The Stock Not Founded..!!");
		}
        return Ok(stock);
    }
    
    [HttpGet("StockWithComments/{id:int}")]
    public async Task<ActionResult> GetByIdWithComments([FromRoute]int id, [FromHeader] string key)
    {
		//> no anyone can access the stock by Id except the Admin
		if (key != _getCommentsKey)
		{
			return BadRequest("The key to get all comments is not valid, the admin only can have this key");
		}

		var stock = await _stockService.GetByIdWithCommentIncludeAsync(id);
        if(stock is null)
        {
			return BadRequest("The Stock Not Founded..!!");
		}
        return Ok(stock);
    }
    
    [HttpGet("{symbol:alpha}")]
    public async Task<ActionResult> GetBySymbol([FromRoute]string symbol)
    {
		//> anyone can access any stock by symbol
        var stock = await _stockService.GetBySymbolAsync(symbol);
        if(stock is null)
        {
			return BadRequest("The Stock Not Founded..!!");
		}
        return Ok(stock);
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult> Create(CreateStockDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _stockService.CreateAsync(model);
        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }
        return StatusCode(201, result);
    }

    [HttpPut("{id:int}")]
	[Authorize]
	public async Task<ActionResult> Update([FromRoute]int id, [FromBody]UpdateStockDto model)
    {
		if (!ModelState.IsValid)
		{
			return BadRequest(ModelState);
		}

		var result = await _stockService.UpdateAsync(id, model);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return StatusCode(200, result);
	}

    [HttpDelete("{id:int}")]
	[Authorize]
	public async Task<ActionResult> Delete([FromRoute] int id)
    {
        var result = await _stockService.DeleteAsync(id);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return StatusCode(200, result);
	}
}
