using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Planets;

namespace MayTheFour.Api.Infrastructure.Planets
{
    public class PlanetRepository : IPlanetRepository
    {
        private readonly ApplicationDbContext _context;

        internal PlanetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Planet planet)
        {
            await _context.Planets.AddAsync(planet);
        }
    }
}
