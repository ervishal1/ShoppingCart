using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Infrastructure.Components
{
	public class CategoriesViewComponent : ViewComponent
	{
		private readonly DataContext _Context;

		public CategoriesViewComponent(DataContext context)
		{
			_Context = context;
		}

		public async Task<IViewComponentResult> InvokeAsync() => View(await _Context.Categories.ToListAsync());

	}
}
