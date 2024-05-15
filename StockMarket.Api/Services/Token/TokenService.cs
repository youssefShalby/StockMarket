

namespace StockMarket.Api.Services;

public class TokenService : ITokenService
{
	private readonly IConfiguration _configuration;
    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public JwtSecurityToken CreateToken(List<Claim> tokenClaims, DateTime tokenExpirationTime)
	{
        return new JwtSecurityToken(
            issuer: _configuration["JWT:issuer"],
            audience: _configuration["JWT:Audiances"],
            claims: tokenClaims,
            notBefore: DateTime.Now,
            expires: tokenExpirationTime,
            signingCredentials: GetCredentials()
            );
	}

    public SymmetricSecurityKey GetKeyFromAppSetting()
    {
        return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:secretKey"]));
    }

    public SigningCredentials GetCredentials()
    {
        return new SigningCredentials(GetKeyFromAppSetting(), SecurityAlgorithms.HmacSha256Signature);
    }

}
