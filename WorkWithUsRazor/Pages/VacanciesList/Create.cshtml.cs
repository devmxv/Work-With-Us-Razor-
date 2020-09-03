using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WorkWithUsRazor.Model;

namespace WorkWithUsRazor.Pages.VacanciesList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        //---Helps to bind directly and not have to use it as a param in the methods below
        [BindProperty]
        public Vacancy Vacancy { get; set; }

        //---Post and store the new vacancy
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //---Added to the queue that is going to be pushed to DB After
                await _db.Vacancy.AddAsync(Vacancy);
                //---Then it is stored
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            } else
            {
                //---Model not valid, GTFO until it is valid!
                return Page();
            }
        }

        
    }
}
