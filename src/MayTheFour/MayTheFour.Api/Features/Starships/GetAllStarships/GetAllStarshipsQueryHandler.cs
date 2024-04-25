using MediatR;

namespace MayTheFour.Api.Features.Starships.GetAllStarships;

public class GetAllStarshipsQueryHandler : IRequestHandler<GetAllStarshipsQuery, List<GetAllStarshipsResponse>>
{
    public Task<List<GetAllStarshipsResponse>> Handle(GetAllStarshipsQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(new List<GetAllStarshipsResponse>());
    }
}
