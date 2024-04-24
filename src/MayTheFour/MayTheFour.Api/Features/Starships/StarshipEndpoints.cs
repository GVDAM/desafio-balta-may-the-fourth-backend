using Carter;
using MayTheFour.Api.Features.Starships.GetAllStarships;
using MediatR;

namespace MayTheFour.Api.Features.Starships;

public class StarshipModule : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var root = app.MapGroup("/api/v1/starship")
            .WithTags("Starship")
            .WithOpenApi();

        root.MapGet("/", GetAll)
            .WithSummary("Get all starships");
    }

    public static async Task<IResult> GetAll(ISender sender)
    {
        var query = new GetAllStarshipsQuery();
        var result = await sender.Send(query);
        return Results.Ok(result);
    }
}
