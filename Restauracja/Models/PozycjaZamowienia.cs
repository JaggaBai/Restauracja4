using Restauracja.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class PozycjaZamowienia
    {
        [Key]
        [Display(Name = "Id")]
        public int IdPozycji { get; set; }

        [Display(Name = "Nazwa")]
        [Required]
        [StringLength(30)]
        public string Nazwa { get; set; }

        //[Display(Name = "Kategoria")]
        //public KategoriaPozycji KategoriaPozycji { get; set; }

        [Display(Name = "Cena")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Cena { get; set; }

        public List<Zamowienie_PozycjaZamowienia> Zamowienie_PozycjaZamowienias { get; set; }
    }
}
