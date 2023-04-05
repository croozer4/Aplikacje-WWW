using AWWW_lab1_gr1_Kulesza;
using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
	public class AuthorController : Controller
	{
		private readonly MyDbContext _dbContext;

		public AuthorController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index(int id)
		{
			var author = _dbContext.Authors!.FirstOrDefault(a => a.Id == id); //Repository.Authors.ToList()[id];
			return View(author);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(string FirstName, string LastName)
		{
			Author author = new Author(FirstName, LastName);

			_dbContext.Authors!.Add(author); //Repository.AddAuthor(author);
			_dbContext.SaveChanges();

			return View("Added", author);
		}
	}
}
