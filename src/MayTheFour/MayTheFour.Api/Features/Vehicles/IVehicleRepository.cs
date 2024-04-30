using MayTheFour.Api.Entities;

namespace MayTheFour.Api.Features.Vehicles
{
    public interface IVehicleRepository
    {
        Task AddAsync(Vehicle vehicle);
    }
}
