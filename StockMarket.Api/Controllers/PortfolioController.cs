

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
    [Authorize]
    public async Task<ActionResult> GetUserPortfolio()
    {
        var userName = User.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Email)!.Value;
        var appUser = await _userManager.FindByEmailAsync(userName);
        var stocks = await _portfolioService.GetUserPortfolioAsync(appUser);
        return Ok(stocks);
    }

    [HttpPost]
    [Authorize]
    public async Task<ActionResult> CreatePortfolio(CreatePortfolioDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

		var userId = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier)?.Value ?? "NA";

		if (userId == "NA") return BadRequest("user not found..!!!");

		model.UserId = userId;

		var result = await _portfolioService.CreatePortfolioAsync(model);
        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }
        return Ok(result);
        
	}

    [HttpDelete]
    [Authorize]
    public async Task<ActionResult> DeletePortfolio(DeletePortfolioDto model)
    {
        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

		var userId = User.Claims.FirstOrDefault(u => u.Type == ClaimTypes.NameIdentifier)?.Value ?? "NA";

		if (userId == "NA") return BadRequest("user not found..!!!");

		model.UserId = userId;

		var result = await _portfolioService.DeletePortfolioAsync(model);
		if (!result.IsSuccessed)
		{
			return BadRequest(result);
		}
		return Ok(result);
	}

}
