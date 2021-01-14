using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nemes_Bianca_Proiect2.Data;
using Nemes_Bianca_Proiect2.Models;

namespace Nemes_Bianca_Proiect2
{
    public class EditModel : PageModel
    {
        private readonly Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context _context;

        public EditModel(Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Artwork Artwork { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artwork = await _context.Artwork.FirstOrDefaultAsync(m => m.ID == id);

            if (Artwork == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Artwork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArtworkExists(Artwork.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ArtworkExists(int id)
        {
            return _context.Artwork.Any(e => e.ID == id);
        }
    }
}
