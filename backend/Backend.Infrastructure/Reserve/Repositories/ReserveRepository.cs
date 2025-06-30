
using Backend.Application.BaseRepository;
using Backend.Domain;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infrastructure.ReserveRepositories
{
    public class ReserveRepository : BaseRepository<Reserve, Guid>
    {
        public ReserveRepository(ApplicationDbContext context)
            : base(context) { }
        public async Task<IEnumerable<Reserve>> GetByDateAsync(DateTime date)
        {
            return await _context.Reserve
                .Where(r => r.DateTimeStart == date)
                .ToListAsync();
        }
        public async Task<IEnumerable<Reserve>> GetAll()
        {
            return await _context.Reserve.ToListAsync();
        }

    }
}
