using Inlämning2byDB.Data;
using Inlämning2byDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
    }
}
