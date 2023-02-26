using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories.Interfaces;
using TourPlanner.Models.Entities;

namespace TourPlanner.DataAccess.Repositories;

public class RatingRepository : Repository<Rating>, IRatingRepository
{
    public RatingRepository(TourContext context)
        : base(context) { }
}