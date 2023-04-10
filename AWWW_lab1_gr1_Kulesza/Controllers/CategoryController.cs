using Microsoft.AspNetCore.Mvc;
using AWWW_lab1_gr1_Kulesza;
using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDbContext _dbContext;

        public CategoryController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index(int id)
        {
            var category = _dbContext.Categories!.FirstOrDefault(a => a.Id == id);
            return View(category);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Add(string Name)
        {
            Category category = new Category(Name);

            _dbContext.Categories!.Add(category);
            _dbContext.SaveChanges();

            return View("Added", category);
        }
    }
}
