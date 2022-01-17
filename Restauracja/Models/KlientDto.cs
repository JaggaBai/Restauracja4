using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Models
{
    public class KlientDto
    {
        
        public int KlientId { get; set; }

        public int NumerStolika { get; set; }
       //nie ujawniamy oceny - 3cia rzecz w klientach
    }
}
