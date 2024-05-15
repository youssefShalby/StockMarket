namespace StockMarket.Api.DTOs;

public class RegisterUserDto
{
    [Required(ErrorMessage = "the user name is required...!!")]
    [MaxLength(50, ErrorMessage = "the user name cannot be larger than 50 char")]
    public string UserName { get; set; } = string.Empty;

    [Required(ErrorMessage = "the email is required...!!")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "the password is required...!!")]
    public string Password { get; set; } = string.Empty;

	[Required(ErrorMessage = "confirm the password ..!!")]
    [Compare(nameof(Password), ErrorMessage = "the passwords doesn't matches")]
	public string ConfirmPassword { get; set; } = string.Empty;

}
