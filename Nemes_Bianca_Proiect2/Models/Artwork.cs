using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nemes_Bianca_Proiect2.Models
{
    public class Artwork
    {
        public int ID { get; set; }
        [Display(Name = "Artwork Title")]
        public string Title { get; set; }
        public string Gallery { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public DateTime OccurrenceDate { get; set; }
        public string Artist { get; set; }
        public string Category { get; set; }
        public string Movement { get; set; }
    }
}
