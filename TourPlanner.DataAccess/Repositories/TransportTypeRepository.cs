using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories.Interfaces;
using TourPlanner.Models.Entities;

namespace TourPlanner.DataAccess.Repositories;

public class TransportTypeRepository : Repository<TransportType>, ITransportTypeRepository
{
    public TransportTypeRepository(TourContext context)
        : base(context) { }
}