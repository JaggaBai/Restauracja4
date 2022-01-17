using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class Klient
    {
        [Key]
        [Display(Name ="Numer Klienta")]
        public int KlientId { get; set; }

        [Display(Name ="Numer Stolika")]
        public int NumerStolika { get; set; }

        [Display(Name = "Ocena")]
        public int Ocena { get; set; }

        public List<Zamownie> Zamownies { get; set; }
    }
}
