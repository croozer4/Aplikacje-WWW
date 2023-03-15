using AWWW_lab1_gr1_Kulesza.Models;
using Microsoft.AspNetCore.Mvc;

namespace AWWW_lab1_gr1_Kulesza.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int id=1)
        {

            var studenci = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Imie = "Uno",
                    Nazwisko = "Test",
                    NumerIndeksu = 123456,
                    DataUrodzenia = DateTime.Now,
                    KierunekStudiow = "Informatyka"
                },
                new Student
                {
                    Id = 2,
                    Imie = "Dos",
                    Nazwisko = "Test",
                    NumerIndeksu = 123456,
                    DataUrodzenia = DateTime.Now,
                    KierunekStudiow = "Informatyka"
                },
                new Student {
                    Id = 3,
                    Imie = "Tres",
                    Nazwisko = "Test",
                    NumerIndeksu = 123456,
                    DataUrodzenia = DateTime.Now,
                    KierunekStudiow = "Informatyka"
                }
            };

            return View(studenci[id - 1]);
        }
    }
}
