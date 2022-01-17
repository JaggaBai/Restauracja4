using Microsoft.EntityFrameworkCore;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data
{
    public class RestDbContext : DbContext
    {
        public RestDbContext(DbContextOptions<RestDbContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Zamowienie_PozycjaZamowienia>().HasKey(zpz => new
            {
                zpz.IdZamownie,
                zpz.IdPozycji
            });
            modelBuilder.Entity<Zamowienie_PozycjaZamowienia>().HasOne(z => z.Zamownie).WithMany(zpz => zpz.Zamowienie_PozycjaZamowienias).HasForeignKey(z => z.IdZamownie);

            modelBuilder.Entity<Zamowienie_PozycjaZamowienia>().HasOne(pz => pz.PozycjaZamowienia).WithMany(zpz => zpz.Zamowienie_PozycjaZamowienias).HasForeignKey(pz => pz.IdPozycji);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Zamownie> Zamownia { get; set; }
       
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<PozycjaZamowienia> PozycjeZamowienia { get; set; }
        public DbSet<Zamowienie_PozycjaZamowienia> Zamowienie_PozycjaZamowienia { get; set; }


    }
}
