using Inlämning2byDB.Data;
using Inlämning2byDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inlämning2byDB.Controllers
{
    public class PersonController : Controller
    {
        // Dependency Injection - Nytt men coolt.
        private readonly ApplicationDbContext _db;

        public PersonController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Person> objList = _db.Persons;
            return View(objList);
        }

        // GET-Create
        public IActionResult Create()
        {
            return View();
        }

        // POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken] // For Safety. 
        public IActionResult Create(Person obj)
        {
            if (ModelState.IsValid)
            {
                _db.Persons.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        // Get-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Persons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken] // For Safety. 
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Persons.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Persons.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
