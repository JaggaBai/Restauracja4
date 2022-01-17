using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Zamownie
    {
        [Key]
        public int IdZamownie { get; set; }
        [Display(Name = "Numer Klienta")]
        public int KlientId { get; set; }

        [Display(Name = "Data zamówienia")]
        public DateTime DataZamowienia { get; set; }

        public List<Zamowienie_PozycjaZamowienia> Zamowienie_PozycjaZamowienias { get; set; }
       

    }
}
