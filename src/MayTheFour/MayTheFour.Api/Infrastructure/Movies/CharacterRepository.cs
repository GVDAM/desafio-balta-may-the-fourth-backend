using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Movies;

namespace MayTheFour.Api.Infrastructure.Movies
{
    public class CharacterRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _context;

        internal CharacterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
        }
    }
}
