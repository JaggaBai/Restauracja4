using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.Services
{
    public interface IPozycjeZamowieniaService
    {
        Task<IEnumerable<PozycjaZamowienia>> PobierzWszystkie();
        void Dodaj(PozycjaZamowienia pozycjaZamowienia);

        void Delate(int id);



    }
}
