namespace StockMarket.Api.Services;

public interface IUserService
{
	Task<CommonResponse> RegisterAsync(RegisterUserDto model);
	Task<CommonResponse> LoginAsync(LoginUserDto model);
	CommonResponse LogoutAsync();
	
}
