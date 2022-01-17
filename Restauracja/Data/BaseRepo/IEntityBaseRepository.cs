using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja.Data.BaseRepo
{
   public interface IEntityBaseRepository<T> where T:class, IEntityBase, new()
    {
        Task<IEnumerable<T>> PobierzWszystkieAsync();
        Task DodajAsync(T entity);

        Task DelateAsync(int id);

    }
}
