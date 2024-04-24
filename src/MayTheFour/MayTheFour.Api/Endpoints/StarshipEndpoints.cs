namespace MayTheFour.Api.Endpoints;

public static class StarshipEndpoints
{
    public static WebApplication MapStarshipEndpoints(this WebApplication app)
    {
        var root = app.MapGroup("/api/v1/starship")
            .WithTags("Starship")
            .WithOpenApi();

        root.MapGet("/", GetAll)
            .WithSummary("Get all starships");
        
        return app;
    }

    public static IResult GetAll()
    {
        return Results.Ok(":-DD");
    }
}
