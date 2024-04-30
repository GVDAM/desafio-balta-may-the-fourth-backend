using MayTheFour.Api.Entities;

namespace MayTheFour.Api.Features.Planets
{
    public interface IPlanetRepository
    {
        Task AddAsync(Planet planet);
    }
}
