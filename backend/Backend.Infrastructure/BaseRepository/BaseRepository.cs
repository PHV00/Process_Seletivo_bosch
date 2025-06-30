
using Backend.Infrastructure;

namespace Backend.Application.BaseRepository
{
    public class BaseRepository<TEntity, TId>
    {
        protected readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

    }
}
