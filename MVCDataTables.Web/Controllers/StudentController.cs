using Microsoft.AspNetCore.Mvc;
using MVCDataTables.Domain.Entities;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Store(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", student);
            }

            _db.Students.Add(student);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var student = _db.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", student);
            }

            _db.Students.Update(student);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var student = _db.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            _db.Students.Remove(student);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var student = _db.Students.Find(id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
    }
}
