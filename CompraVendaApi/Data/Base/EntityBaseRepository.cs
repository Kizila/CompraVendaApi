using Microsoft.EntityFrameworkCore;

namespace CompraVendaApi.Data.Base
{
    public class EntityBaseRepository: IEntityBaseRepository
    {
        AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        //public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();

        //public async Task<T> GetByIDAsync(int id) => await _context.Set<T>().FirstOrDefaultAsync(a => a.apresentacao_id == id);
    }
}
