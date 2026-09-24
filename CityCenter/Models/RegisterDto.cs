using System.ComponentModel.DataAnnotations;

namespace CityCenter.Models
{
	public class RegisterDto
	{
		[Required(ErrorMessage = "The First Name field is required"), MaxLength(100)]
		public string FirstName { get; set; } = "";

		[Required(ErrorMessage = "The Last Name field is required"), MaxLength(100)]
		public string LastName { get; set; } = "";

		[Required, EmailAddress, MaxLength(100)]
		public string Email { get; set; } = "";

		[Phone(ErrorMessage = "Please Enter Valid Phone Number"), MaxLength(20)]
		public string? PhoneNumber { get; set; }

		[Required, MaxLength(200)]
		public string Address { get; set; } = "";

		[Required, MaxLength(100)]
		public string Password { get; set; } = "";

		[Required(ErrorMessage = "The Confirm Password field is required")]
		[Compare("Password", ErrorMessage = "Confirm Password and Password do not match")]
		public string ConfirmPassword { get; set; } = "";
	}
}
