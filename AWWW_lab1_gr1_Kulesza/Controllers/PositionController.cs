using AWWW_lab1_gr1_Kulesza;
using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
	public class PositionController : Controller
	{
		private readonly MyDbContext _dbContext;

		public PositionController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index(int id)
		{
			var position = _dbContext.Positions!.FirstOrDefault(a => a.Id == id); //Repository.Positions.ToList()[id];
			return View(position);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(string Name)
		{
			Position position = new Position(Name);

			_dbContext.Positions!.Add(position); //Repository.AddPosition(position);
			_dbContext.SaveChanges();

			return View("Added", position);
		}
	}
}
