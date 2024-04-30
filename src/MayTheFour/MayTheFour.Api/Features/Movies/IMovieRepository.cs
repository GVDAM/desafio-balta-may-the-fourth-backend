using MayTheFour.Api.Entities;

namespace MayTheFour.Api.Features.Movies
{
    public interface IMovieRepository
    {
        Task AddAsync(Movie movie);
    }
}
