using MayTheFour.Api.Entities;

namespace MayTheFour.Api.Features.Starships
{
    public interface IStarshipRepository
    {
        Task AddAsync(Starship starship);
    }
}
