using Microsoft.EntityFrameworkCore;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.Services
{
    public class PozycjeZamowieniaService : IPozycjeZamowieniaService
    {
        private readonly RestDbContext _context;
        public PozycjeZamowieniaService(RestDbContext context)
        {
            _context = context;
        }
        public void Delate(int id)
        {
            throw new NotImplementedException();
        }

        public void Dodaj(PozycjaZamowienia pozycjaZamowienia)
        {
            _context.PozycjeZamowienia.Add(pozycjaZamowienia);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<PozycjaZamowienia>> PobierzWszystkie()
        {
            var res = await _context.PozycjeZamowienia.ToListAsync();
            return res;
        }

    }
}

