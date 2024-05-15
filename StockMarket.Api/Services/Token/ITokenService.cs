namespace StockMarket.Api.Services;

public interface ITokenService
{
	JwtSecurityToken CreateToken(List<Claim> claims, DateTime expirationTime);
	SymmetricSecurityKey GetKeyFromAppSetting();
	SigningCredentials GetCredentials();

}
