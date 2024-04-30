using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Characters;

namespace MayTheFour.Api.Infrastructure.Characters
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly ApplicationDbContext _context;

        internal CharacterRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Character character)
        {
            await _context.Characters.AddAsync(character);
        }
    }
}
