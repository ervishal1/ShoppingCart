using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShoppingCart.Models.ViewModels
{
	public class LoginViewModel
	{
		[Required, MinLength(2, ErrorMessage = "Minimum Length is 2")]
		[Display(Name = "UserName")]
		public string UserName { get; set; }

		[DataType(DataType.Password), Required, MinLength(4, ErrorMessage = "Minimum Length is 4")]
		public string Password { get; set; }

		public string ReturnUrl { get; set; }
	}
}
