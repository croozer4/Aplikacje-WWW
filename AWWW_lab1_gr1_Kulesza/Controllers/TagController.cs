using AWWW_lab1_gr1_Kulesza;
using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
	public class TagController : Controller
	{
		private readonly MyDbContext _dbContext;

		public TagController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index(int id)
		{
			var tag = _dbContext.Tags!.FirstOrDefault(a => a.Id == id); //Repository.Tags.ToList()[id];
			return View(tag);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(string Name)
		{
			Tag tag = new Tag(Name);

			_dbContext.Tags!.Add(tag); //Repository.AddTag(tag);
			_dbContext.SaveChanges();

			return View("Added", tag);
		}
	}
}
