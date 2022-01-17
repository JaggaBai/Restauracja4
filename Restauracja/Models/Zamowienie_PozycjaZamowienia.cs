using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Zamowienie_PozycjaZamowienia
    {
       
        public int Liczba { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public double Cena { get; set; }

        [ForeignKey("IdZamownie")]
        public int IdZamownie { get; set; }
        public Zamownie Zamownie { get; set; }

        [ForeignKey("IdPozycji")]
        public int IdPozycji { get; set; }
        
        public PozycjaZamowienia PozycjaZamowienia { get; set; }
    }
}
