using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nemes_Bianca_Proiect2.Data;
using Nemes_Bianca_Proiect2.Models;

namespace Nemes_Bianca_Proiect2
{
    public class DeleteModel : PageModel
    {
        private readonly Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context _context;

        public DeleteModel(Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Artwork = await _context.Artwork.FindAsync(id);

            if (Artwork != null)
            {
                _context.Artwork.Remove(Artwork);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
