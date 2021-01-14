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
    public class IndexModel : PageModel
    {
        private readonly Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context _context;

        public IndexModel(Nemes_Bianca_Proiect2.Data.Nemes_Bianca_Proiect2Context context)
        {
            _context = context;
        }

        public IList<Artwork> Artwork { get;set; }

        public async Task OnGetAsync()
        {
            Artwork = await _context.Artwork.ToListAsync();
        }
    }
}
