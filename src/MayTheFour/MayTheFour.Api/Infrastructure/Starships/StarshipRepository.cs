using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Starships;

namespace MayTheFour.Api.Infrastructure.Starships
{
    public class StarshipRepository : IStarshipRepository
    {
        private readonly ApplicationDbContext _context;

        internal StarshipRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Starship starship)
        {
            await _context.Starships.AddAsync(starship);
        }
    }
}
