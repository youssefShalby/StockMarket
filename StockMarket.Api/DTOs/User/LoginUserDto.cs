namespace StockMarket.Api.DTOs;

public class LoginUserDto
{
	[Required(ErrorMessage = "invalid email...!!")]
	[EmailAddress]
	public string Email { get; set;} = string.Empty;

	[Required(ErrorMessage = "invalid password...!!")]
	public string Password { get; set; } = string.Empty;
}
