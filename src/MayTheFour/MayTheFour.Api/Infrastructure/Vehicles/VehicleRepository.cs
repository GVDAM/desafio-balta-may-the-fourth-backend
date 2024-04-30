using MayTheFour.Api.Entities;
using MayTheFour.Api.Features.Vehicles;

namespace MayTheFour.Api.Infrastructure.Vehicles
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly ApplicationDbContext _context;

        internal VehicleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Vehicle vehicle)
        {
            await _context.Vehicles.AddAsync(vehicle);
        }
    }
}
