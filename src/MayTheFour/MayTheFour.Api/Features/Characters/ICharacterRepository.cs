using MayTheFour.Api.Entities;

namespace MayTheFour.Api.Features.Characters
{
    public interface ICharacterRepository
    {
        Task AddAsync(Character character);
    }
}
