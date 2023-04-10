using AWWW_lab1_gr1_Kulesza;
using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
	public class EventTypeController : Controller
	{
		private readonly MyDbContext _dbContext;

		public EventTypeController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index(int id)
		{
			var eventType = _dbContext.Categories!.FirstOrDefault(a => a.Id == id); //Repository.EventTypes.ToList()[id];
			return View(eventType);
		}

		public IActionResult Add()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Add(string Name)
		{
			EventType eventType = new EventType(Name);

			_dbContext.EventTypes!.Add(eventType); //Repository.AddEventType(eventType);
			_dbContext.SaveChanges();

			return View("Added", eventType);
		}
	}
}
