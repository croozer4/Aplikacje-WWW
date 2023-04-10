using AWWW_lab1_gr1_Kulesza;
using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
	public class LeagueController : Controller
	{
		private readonly MyDbContext _dbContext;

		public LeagueController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index(int id)
		{
			var league = _dbContext.Leagues!.FirstOrDefault(a => a.Id == id); //Repository.Leagues.ToList()[id];
			return View(league);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(string Name, string Country, int Level)
		{
			League league = new League(Name, Country, Level);

			_dbContext.Leagues!.Add(league); //Repository.AddLeague(league);
			_dbContext.SaveChanges();

			return View("Added", league);
		}
	}
}
