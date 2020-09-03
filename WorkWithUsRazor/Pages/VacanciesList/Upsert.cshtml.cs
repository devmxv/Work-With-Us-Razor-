using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WorkWithUsRazor.Model;

namespace WorkWithUsRazor.Pages.VacanciesList
{
    public class UpsertModel : PageModel
    {
        private ApplicationDbContext _db;

        public UpsertModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Vacancy Vacancy { get; set; }

        public async Task<IActionResult> OnGet(int? id)
        {
            Vacancy = new Vacancy();
            if(id == null)
            {
                return Page();
            }

            //---For update
            Vacancy = await _db.Vacancy.FirstOrDefaultAsync(u => u.Id == id);
            //---If not found
            if(Vacancy == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            //---If validation is correct, proceed
            if (ModelState.IsValid)
            {
                //---No id submitted, it is a create action
                if(Vacancy.Id == 0)
                {
                    _db.Vacancy.Add(Vacancy);
                } else
                {
                    _db.Vacancy.Update(Vacancy);
                }

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }

        
    }
}
