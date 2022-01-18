using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.BaseRepo
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly RestDbContext _context;
        public EntityBaseRepository(RestDbContext context)
        {
            _context = context;
        }


        public async Task DelateAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }

        public async Task DodajAsync(T entity)
        {
          await _context.Set<T>().AddAsync(entity);
          await _context.SaveChangesAsync();
        }


        public async Task<IEnumerable<T>> PobierzWszystkieAsync() => await _context.Set<T>().ToListAsync();
            
        
    }
}
    
