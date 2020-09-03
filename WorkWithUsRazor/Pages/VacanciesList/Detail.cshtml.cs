using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkWithUsRazor.Model;

namespace WorkWithUsRazor.Pages.VacanciesList
{
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        //---Dependency Injection
        public DetailModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Vacancy Vacancy { get; set; }

        //---On Edit, passing the id from front
        public async Task OnGet(int id)
        {
            Vacancy = await _db.Vacancy.FindAsync(id);
        }
    }
}
