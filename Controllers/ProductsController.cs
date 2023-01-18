using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Infrastructure;

namespace ShoppingCart.Controllers
{
	public class ProductsController : Controller
	{

		private readonly DataContext _context;

		public ProductsController(DataContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
