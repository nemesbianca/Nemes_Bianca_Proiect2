using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nemes_Bianca_Proiect2.Data;
using Nemes_Bianca_Proiect2.Models;

namespace Nemes_Bianca_Proiect2
{
    public class CreateModel : PageModel
    {
        private readonly Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context _context;

        public CreateModel(Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Artwork Artwork { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Artwork.Add(Artwork);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
