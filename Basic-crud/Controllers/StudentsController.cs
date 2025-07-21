using Basic_crud.Data;
using Basic_crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_crud.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext context;
        public StudentsController(ApplicationDbContext context) 
        { 
            this.context = context;
        }
        public IActionResult Index()
        {
            var students = this.context.Students.ToList();  // Students is our tbName
            //var students = this.context.Students.OrderByDescending(s => s.Id).ToList();  
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] 
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                this.context.Students.Add(student);
                this.context.SaveChanges();
                return RedirectToAction("index");
            }

            return View(student);
        }

        //for get data
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = context.Students.Find(id);
            if (student == null) return NotFound();
            return View(student);
        }

        // for update
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                this.context.Students.Update(student);
                this.context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            if (student == null) return NotFound();

            context.Students.Remove(student);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
