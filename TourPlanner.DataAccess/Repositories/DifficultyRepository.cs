using TourPlanner.DataAccess.Context;
using TourPlanner.DataAccess.Repositories.Interfaces;
using TourPlanner.Models.Entities;

namespace TourPlanner.DataAccess.Repositories;

public class DifficultyRepository : Repository<Difficulty>, IDifficultyRepository
{
    public DifficultyRepository(TourContext context)
        : base(context) { }
}