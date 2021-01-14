using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nemes_Bianca_Proiect2.Models;

namespace Nemes_Bianca_Proiect2.Data
{
    public class Nemes_Bianca_Proiect2Context : DbContext
    {
        public Nemes_Bianca_Proiect2Context (DbContextOptions<Nemes_Bianca_Proiect2Context> options)
            : base(options)
        {
        }

        public DbSet<Nemes_Bianca_Proiect2.Models.Artwork> Artwork { get; set; }
    }
}
