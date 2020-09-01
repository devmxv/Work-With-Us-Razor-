using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkWithUsRazor.Model;

namespace WorkWithUsRazor.Controllers
{
    public class VacancyController : Controller
    {
        //---Define connection
        private readonly ApplicationDbContext _db;

        //---Using Dependency Injection
        public VacancyController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
