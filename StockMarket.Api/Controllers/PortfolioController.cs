

namespace StockMarket.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
[Authorize]
public class PortfolioController : ControllerBase
{
	private readonly IPortfolioService _portfolioService;
	private readonly UserManager<ApplicationUser> _userManager;
    public PortfolioController(IPortfolioService portfolioService, UserManager<ApplicationUser> userManager)
    {
        _portfolioService = portfolioService;
        _userManager = userManager;
    }

    [HttpGet]
    public async Task<ActionResult> GetUserPortfolio()
    {
        var userName = User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)!.Value;
        var appUser = await _userManager.FindByEmailAsync(userName);
        var stocks = await _portfolioService.GetUserPortfolioAsync(appUser);
        return Ok(stocks);
    }

    [HttpPost]
    public async Task<ActionResult> CreatePortfolio(CreatePortfolioDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var result = await _portfolioService.CreatePortfolioAsync(model);
        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }
        return Ok(result);
        
	}

    [HttpDelete]
    public async Task<ActionResult> DeletePortfolio(DeletePortfolioDto model)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
		var result = await _portfolioService.DeletePortfolioAsync(model);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return Ok(result);
	}

}
