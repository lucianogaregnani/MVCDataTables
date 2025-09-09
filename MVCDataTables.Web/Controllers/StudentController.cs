using Microsoft.AspNetCore.Mvc;
using MVCDataTables.Infrastructure.Context;

namespace MVCDataTables.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDBContext _db;

        public StudentController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var students = _db.Students.ToList();
            return View(students);
        }
    }
}
