using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Infrastructure.TagHelpers.Validation
{
	public class FileExtensionAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value,ValidationContext validationContext)
		{
			if(value is IFormFile file)
			{
				var extension = Path.GetExtension(file.FileName);

				string[] extensions = { "jpg", "png" };
				bool result = extensions.Any(x => extension.EndsWith(x));

				if (!result)
				{
					return new ValidationResult("Allowed Extensions are jpg and png");
				}
			}

			return ValidationResult.Success;
		}
	}
}
