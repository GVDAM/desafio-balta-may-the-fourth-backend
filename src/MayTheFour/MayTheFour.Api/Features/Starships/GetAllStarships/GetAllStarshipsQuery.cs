using MediatR;

namespace MayTheFour.Api.Features.Starships.GetAllStarships;

public record GetAllStarshipsQuery : IRequest<List<GetAllStarshipsResponse>> {}

public record GetAllStarshipsResponse(
    string Name, string Model, string Manufacturer, string CostInCredits,
    string Length, string MaxSpeed, string Crew, string Passengers,
    string CargoCapacity, string HyperdriveRating, string Mgtl, string Consumables,
    string Class, List<object> Movies);