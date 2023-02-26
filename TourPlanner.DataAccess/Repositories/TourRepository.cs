using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories.Interfaces;
using TourPlanner.Models.Entities;

namespace TourPlanner.DataAccess.Repositories;

public class TourRepository : Repository<Tour>, ITourRepository
{
    public TourRepository(TourContext context)
        : base(context) { }
}