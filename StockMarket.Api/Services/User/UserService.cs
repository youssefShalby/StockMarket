

namespace StockMarket.Api.Services;

public class UserService : IUserService
{
	private readonly UserManager<ApplicationUser> _userManager;
    private readonly ITokenService _tokenService;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IHandlerService _handlerService;
    public UserService(UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor, ITokenService tokenService, IHandlerService handlerService)
    {
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
        _tokenService = tokenService;
        _handlerService = handlerService;
    }

	public async Task<CommonResponse> LoginAsync(LoginUserDto model)
	{
		var httpContext = _httpContextAccessor.HttpContext;
        var checkTokenIsExist = httpContext?.Request.Cookies.FirstOrDefault(TK => TK.Key == "loginToken");
        if(checkTokenIsExist?.Value is not null)
        {
            return new CommonResponse("User already loged in..!!", true);
        }

        var account = await _userManager.FindByEmailAsync(email: model.Email);
        if(account is null)
        {
            return new CommonResponse("account not founded..!!", false);
        }

        if(await _userManager.IsLockedOutAsync(account))
        {
            return new CommonResponse("account is blocked for a while, we will unblock it soon..!!", true);
        }

        var isPasswordRight = await _userManager.CheckPasswordAsync(account, model.Password);
        if (!isPasswordRight)
        {
			return new CommonResponse("password is incorrect..!!", true);
        }

		var userClaims = await _userManager.GetClaimsAsync(account);
        userClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, new Guid().ToString()));

        var tokenObject = _tokenService.CreateToken(userClaims.ToList(), DateTime.Now.AddHours(12));
        string token = new JwtSecurityTokenHandler().WriteToken(tokenObject);

		//> save token at the browser
		var cookieOption = new CookieOptions
        {
            Expires = tokenObject.ValidTo
        };
        httpContext?.Response.Cookies.Append("loginToken", token, cookieOption);

        return new CommonResponse("login in success", true, null!, new TokenDto { Token = token, ExpireTime = tokenObject.ValidTo });
	}

	public CommonResponse LogoutAsync()
	{
        var httpContext = _httpContextAccessor.HttpContext;
        httpContext?.Response.Cookies.Delete("loginToken");
        return new CommonResponse("loged out..!!", true);
	}

	public async Task<CommonResponse> RegisterAsync(RegisterUserDto model)
	{
		var isUserNameExist = await _userManager.FindByNameAsync(model.UserName);
        if (isUserNameExist is not null)
        {
            return new CommonResponse("User Name Already Exist, try another one..!!", false);
        }

        var isEmailExist = await _userManager.FindByEmailAsync(model.Email);
        if(isEmailExist is not null)
        {
			return new CommonResponse("User Email Already Taken, try another one..!!", false);
		}

        ApplicationUser appUser = new()
        {
            UserName = model.UserName,
            Email = model.Email,
        };

        List<Claim> appUserClaims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, appUser.Id),
            new Claim(ClaimTypes.Name, appUser.UserName),
            new Claim(ClaimTypes.Email, appUser.Email),
        };

        var result = await _userManager.CreateAsync(appUser, model.Password);
        if (!result.Succeeded)
        {
            var errors = _handlerService.GetResultErrors(result.Errors);
            return new CommonResponse("cannot create account right now", false, errors);
        }

        var addClaimsResult = await _userManager.AddClaimsAsync(appUser, appUserClaims);
		if (!addClaimsResult.Succeeded)
		{
			var errors = _handlerService.GetResultErrors(addClaimsResult.Errors);
			return new CommonResponse("cannot create account right now", false, errors);
		}
		return new CommonResponse("Account Created", true);

	}

}
