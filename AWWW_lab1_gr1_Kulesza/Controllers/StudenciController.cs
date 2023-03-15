using Microsoft.AspNetCore.Mvc;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
    public class StudenciController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Studenci";
            return View();
        }
    }
}
