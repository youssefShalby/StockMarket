

namespace StockMarket.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class StocksController : ControllerBase
{
	private readonly IStockService _stockService;
    public StocksController(IStockService stockService)
    {
        _stockService = stockService;
    }

    [HttpGet("p/{pageNumber}")]
    public async Task<ActionResult> GetAll([FromRoute]int pageNumber)
    {
        var stocks = await _stockService.GetAllAsync(pageNumber);
        if(stocks is null)
        {
            return BadRequest("cannot get the stocks right now, try again later..!!");
        }
        return Ok(stocks);
    }

	[HttpGet("C/{pageNumber}")]
	public async Task<ActionResult> GetAllWithComments([FromRoute] int pageNumber)
	{
		var stocks = await _stockService.GetAlldWithCommentIncludeAsync(pageNumber);
		if (stocks is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(stocks);
	}

	[HttpGet("f")]
	public async Task<ActionResult> GetAllWithFilters([FromBody] StockQueryHandler handler)
	{
		var stocks = await _stockService.GetAllWithFilterAsync(handler);
		if (stocks is null)
		{
			return BadRequest("cannot get the stocks right now, try again later..!!");
		}
		return Ok(stocks);
	}

	[HttpGet("{id:int}")]
    public async Task<ActionResult> GetById([FromRoute]int id)
    {
        var stock = await _stockService.GetByIdAsync(id);
        if(stock is null)
        {
			return BadRequest("The Stock Not Founded..!!");
		}
        return Ok(stock);
    }
    
    [HttpGet("C/{id:int}")]
    public async Task<ActionResult> GetByIdWithComments([FromRoute]int id)
    {
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
