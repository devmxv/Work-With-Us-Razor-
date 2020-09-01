using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkWithUsRazor.Model;

namespace WorkWithUsRazor.Pages.VacanciesList
{
    public class IndexModel : PageModel
    {
        //---Connection with Db
        private readonly ApplicationDbContext _db;
        //---Dependency Injection
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //---using a list to store all the vacancies in one object
        public IEnumerable<Vacancy> Vacancies { get; set; }


        public async Task OnGet()
        {
            //---Retrieve all Vacancies stored
            Vacancies = await _db.Vacancy.ToListAsync();
        }
    }
}
