using Microsoft.EntityFrameworkCore;
using Restauracja.Data.BaseRepo;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.Services
{
    public class PozycjeZamowieniaService : EntityBaseRepository<PozycjaZamowienia>, IPozycjeZamowieniaService
    { public PozycjeZamowieniaService(RestDbContext context):base(context) { }
    }
        //private readonly RestDbContext _context;
        //public PozycjeZamowieniaService(RestDbContext context)
        //{
        //    _context = context;
        //}
        //public void Delate(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Dodaj(PozycjaZamowienia pozycjaZamowienia)
        //{
        //    _context.PozycjeZamowienia.Add(pozycjaZamowienia);
        //    _context.SaveChanges();
        //}


        //public async Task<IEnumerable<PozycjaZamowienia>> PobierzWszystkieAsync()
        //{
        //    var res = await _context.PozycjeZamowienia.ToListAsync();
        //    return res;
        //}

    }


