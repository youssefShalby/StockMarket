

namespace StockMarket.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AccountController : ControllerBase
{
	private readonly IUserService _userService;
    public AccountController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Register")]
    public async Task<ActionResult> Register(RegisterUserDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = await _userService.RegisterAsync(model);
        if (!result.IsSuccessed)
        {
            return BadRequest(result);
        }
        return StatusCode(201, result);
    }

	[HttpPost("Login")]
	public async Task<ActionResult> Login(LoginUserDto model)
	{
		if (!ModelState.IsValid)
		{
			return Unauthorized(ModelState);
		}

		var result = await _userService.LoginAsync(model);
		if (!result.IsSuccessed)
		{
			return Unauthorized(result);
		}
		return Ok(result.AdditionalInfo);
	}

    [HttpGet("Logout")]
    public ActionResult Logout()
    {
        return Ok(_userService.LogoutAsync());
    }
}
